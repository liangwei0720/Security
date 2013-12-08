using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Monitor.Component.Model;
using Monitor.Component.BLL;
using Monitor.Component;

namespace Monitor.Manager.StudentForm
{
	public partial class SaveGoods : Form
	{
		#region 变量
		private Goods oGoods = new Goods( );
		/// <summary>
		/// 学生基本信息
		/// </summary>
		public static Students StudentInfo { get; set; }
		/// <summary>
		/// 物品的标识
		/// </summary>
		public Guid GoodsID { get; set; }

		/// <summary>
		/// 选择的标签信息
		/// </summary>
		public static Labels LabelInfo { get; set; }

		DormRooms oDormRoom;
		#endregion

		#region 方法
		public SaveGoods ( )
		{
			InitializeComponent( );
			dtPick.MaxDate = DateTime.Now.AddHours( 1 );
			dtPick.MinDate = DateTime.Now.AddYears( -10 );
			dtPick.Value = DateTime.Now;
		}

		/// <summary>
		/// 获取用户上传的图片信息
		/// </summary>
		/// <returns></returns>
		private byte[] GetImage ( )
		{
			if ( this.txtStudentName.Text.Trim( ).Length == 0 )
			{
				return null;
			}
			try
			{
				FileInfo fi = new FileInfo( this.txtStudentName.Text );
				long imgLength = fi.Length;

				//将图片转为2进制保存
				MemoryStream stream = new MemoryStream( );
				Image.FromFile( this.txtStudentName.Text ).Save( stream , ImageFormat.Bmp );
				byte[] byteImage = new byte[imgLength];
				byteImage = stream.ToArray( );

				return byteImage;
			}
			catch ( Exception ex )
			{
				return null;
			}
		}
		/// <summary>
		/// 为图片控件赋值
		/// </summary>
		/// <param name="byteImage"></param>
		private void SetImageToPicture (byte[] byteImage)
		{
			try
			{
				MemoryStream stream = new MemoryStream( );
				stream.Write( byteImage , 0 , byteImage.Length );
				this.pictureBox1.Image = Image.FromStream( stream );
			}
			catch ( Exception ex )
			{
				throw ex;
			}
		}

		private void LoadData ( )
		{
			string [] labelStatus = Enum.GetNames( typeof( Monitor.Component.StaticValue.CurrentStatus ) );
			cmbLabelStatus.DataSource = labelStatus;

			if ( GoodsID == Guid.Empty )
			{
				return;
			}

			DataTable dt = new GoodsManager( ).GetGoods( GoodsID );

			if ( dt != null )
			{
				List<Students> oList = new StudentManager( ).GetAllStudents( "nvcStudentNumber=" + dt.Rows[0]["nvcStudentNumber"].ToString( ) );
				if ( oList == null || oList.Count == 0 )
				{
					MessageBox.Show( "未找到该物品对应的学生信息" , "警告" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
					this.Close( );
					return;
				}

				ParseModel( dt );

				txtGoodsName.TextValue = oGoods.GoodsName;
				txtBrand.TextValue = oGoods.Brand;
				txtModel.TextValue = oGoods.Model;
				txtPrice.TextValue = oGoods.Price.ToString( "F2" );
				dtPick.Value = oGoods.UseDate;
				if ( oGoods.InvoiceInfo != null && oGoods.InvoiceInfo.Length > 0 )
				{
					SetImageToPicture( oGoods.InvoiceInfo );
				}
				txtStudentName.Text = oList[0].StudentName;

				txtLabelNumber.Text = oGoods.LabelNumber;

				this.Text = this.lblTitle.Text = "编辑学生物品信息";
			}
		}

		private void ParseModel (DataTable odtTable)
		{
			oGoods.GoodsID = odtTable.Rows[0]["guGoodsID"] is DBNull ? Guid.Empty : ( Guid )odtTable.Rows[0]["guGoodsID"];
			oGoods.Brand = odtTable.Rows[0]["nvcBrand"] is DBNull ? "" : ( string )odtTable.Rows[0]["nvcBrand"];
			oGoods.Model = odtTable.Rows[0]["nvcModel"] is DBNull ? "" : ( string )odtTable.Rows[0]["nvcModel"];
			oGoods.Invoice = odtTable.Rows[0]["bInvoice"] is DBNull ? false : ( bool )odtTable.Rows[0]["bInvoice"];
			oGoods.InvoiceInfo = odtTable.Rows[0]["vbinInvoiceInfo"] is DBNull ? null : ( byte[] )odtTable.Rows[0]["vbinInvoiceInfo"];
			oGoods.AddDate = odtTable.Rows[0]["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )odtTable.Rows[0]["dtAddDate"];
			oGoods.Status = odtTable.Rows[0]["iStatus"] is DBNull ? ( short )0 : ( short )odtTable.Rows[0]["iStatus"];
			oGoods.Remark = odtTable.Rows[0]["nvcRemark"] is DBNull ? "" : ( string )odtTable.Rows[0]["nvcRemark"];
			oGoods.UseDate = odtTable.Rows[0]["dtUseDate"] is DBNull ? DateTime.Now : ( DateTime )odtTable.Rows[0]["dtUseDate"];
			oGoods.LabelNumber = odtTable.Rows[0]["nvcLabelNumber"] is DBNull ? "" : ( string )odtTable.Rows[0]["nvcLabelNumber"];
			oGoods.StudentNumber = odtTable.Rows[0]["nvcStudentNumber"] is DBNull ? "" : ( string )odtTable.Rows[0]["nvcStudentNumber"];
			oGoods.Price = odtTable.Rows[0]["mPrice"] is DBNull ? 0 : Convert.ToDouble( odtTable.Rows[0]["mPrice"] );
			oGoods.GoodsName = odtTable.Rows[0]["nvcGoodsName"] is DBNull ? "" : ( string )odtTable.Rows[0]["nvcGoodsName"];

		}

		private void ClearControlValue ( )
		{
			this.txtBrand.TextValue = this.txtGoodsName.TextValue = this.txtModel.TextValue = this.txtPrice.TextValue = string.Empty;
			this.dtPick.Value = DateTime.Now;
			this.pictureBox1.Image = null;
			this.textBox3.Text = string.Empty;
			this.txtLabelNumber.Text = string.Empty;
		}
		#endregion


		#region 事件
		private void button1_Click (object sender , EventArgs e)
		{
			SelectStudent os = new SelectStudent( );
			os.Show( );

		}

		private void SaveGoods_Load (object sender , EventArgs e)
		{
			LoadData( );
		}

		private void btnUpload_Click (object sender , EventArgs e)
		{

			if ( this.openFileDialog1.ShowDialog( ) == DialogResult.OK )
			{
				this.txtStudentName.Text = this.openFileDialog1.FileName;
				this.pictureBox1.ImageLocation = this.txtStudentName.Text;
			}
		}

		private void btnSubmit_Click (object sender , EventArgs e)
		{
			if ( txtStudentName.Text.Trim( ).Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请选择学生信息" );
				txtStudentName_DoubleClick( null , null );
				return;
			}

			if ( txtLabelNumber.Text.Trim( ).Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请选择标签信息" );
				txtLabelNumber_DoubleClick( null , null );
				return;
			}

			if ( txtGoodsName.TextValue.Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请输入物品的名称" );
				this.txtGoodsName.Focus( );
				return;
			}
			if ( this.txtBrand.TextValue.Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请输入物品的品牌" );
				this.txtBrand.Focus( );
				return;
			}

			if ( this.txtModel.TextValue.Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请输入物品的型号" );
				this.txtModel.Focus( );
				return;
			}



			Students oStudentInfo = StudentInfo ?? new Students { RoomID = new StudentManager( ).GetStudent( oGoods.StudentNumber ).RoomID };
			oDormRoom = DormRoomManager.GetDormRooms( oStudentInfo.RoomID );

			if ( this.GoodsID == Guid.Empty )
			{
				oGoods.AddDate = DateTime.Now;
				oGoods.GoodsID = Guid.NewGuid( );

				if ( oDormRoom == null || oDormRoom.RoomID == Guid.Empty )
				{
					CommonMethod.ShowWaringMessage( "该学生宿舍信息不明确，请确认是否分配过宿舍。" );

					return;
				}
			}

			double price;

			oGoods.Brand = txtBrand.TextValue;
			oGoods.GoodsName = txtGoodsName.TextValue;
			oGoods.Invoice = rbtnYes.Checked;
			oGoods.Model = txtModel.TextValue;
			oGoods.UseDate = dtPick.Value;

			double.TryParse( txtPrice.TextValue , out price );
			oGoods.Price = price;
			if ( StudentInfo != null )
			{
				oGoods.StudentNumber = StudentInfo.StudentNumber;
			}

			oGoods.LabelNumber = txtLabelNumber.Text.Trim( );

			byte[] oImage = GetImage( );
			if ( oImage != null && oImage.Length > 0 )
			{
				oGoods.InvoiceInfo = oImage;
			}


			if ( new GoodsManager( ).AddGoods( oGoods ) )
			{
				if ( this.GoodsID == Guid.Empty )
				{
					if ( LabelManager.UpdateLabelStatus( "nvcLabelNumber='" + txtLabelNumber.Text.Trim( ) + "'" , oDormRoom.DormID , ( int )StaticValue.LabelStatus.已分配 ) )
					{
						var updateToClient = SaveGoodsInfoToClient( );
						if ( !updateToClient )
						{
							MessageBox.Show( "信息提交成功。但更新当前信息到客户端失败，请重新编辑此信息。" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
							this.Close( );

							return;
						}

						if ( DialogResult.Yes == MessageBox.Show( "信息提交成功。是否继续添加信息？" , "提示" , MessageBoxButtons.YesNo , MessageBoxIcon.Information ) )
						{
							ClearControlValue( );
						}
						else
						{
							this.Close( );
						}
					}
					else
					{
						CommonMethod.ShowWaringMessage( "关联标签信息失败。你可以在稍候进行编辑此信息" );
						this.Close( );
					}
				}
				else
				{
					if ( LabelManager.UpdateLabelStatus( "nvcLabelNumber='" + txtLabelNumber.Text.Trim( ) + "'" , oDormRoom.DormID , ( int )StaticValue.LabelStatus.已分配 ) )
					{
						var updateToClient = SaveGoodsInfoToClient( );
						if ( !updateToClient )
						{
							MessageBox.Show( "信息提交成功。但更新当前信息到客户端失败，请重新编辑此信息。" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
							this.Close( );

							return;
						}
						MessageBox.Show( "信息提交成功" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );
					}
					else
					{
						CommonMethod.ShowWaringMessage( "关联标签信息失败。你可以在稍候进行编辑此信息" );
					}
					this.Close( );
				}
			}
			else
			{
				MessageBox.Show( "信息提交失败，请稍候再试。" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );
			}
		}

		private void txtStudentName_DoubleClick (object sender , EventArgs e)
		{
			SelectStudent oSelectStudent = new SelectStudent( );
			oSelectStudent.ShowDialog( );

			if ( StudentInfo != null )
			{
				txtStudentName.Text = StudentInfo.StudentName;
			}
		}

		private void btnCancel_Click (object sender , EventArgs e)
		{
			this.Close( );
		}
		#endregion

		private void txtLabelNumber_DoubleClick (object sender , EventArgs e)
		{
			LabelForm.SelectLabel oSelectLabel = new LabelForm.SelectLabel( );
			oSelectLabel.ShowDialog( );

			if ( LabelInfo != null )
			{
				txtLabelNumber.Text = LabelInfo.LabelNumber;
			}
		}

		private bool SaveGoodsInfoToClient ( )
		{
			var studentInfo = StudentInfo ?? new StudentManager( ).GetStudent( oGoods.StudentNumber );

            var room = DormRoomManager.GetDormRooms (studentInfo.RoomID);

			var servers = ServerManager.GetServersByDormID( room.DormID );

			var labelInfo = LabelInfo ?? LabelManager.GetLabels( txtLabelNumber.Text.Trim( ) );

			bool success = true;

			foreach ( Server server in servers )
			{
				if ( !new GoodsManager( ).AddGoodsToClient( oGoods , studentInfo , labelInfo , server.Connection ) )
				{
					success = false;
					break;
				}
			}

			return success;
		}

	}
}
