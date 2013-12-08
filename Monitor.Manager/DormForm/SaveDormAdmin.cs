using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Monitor.Component.BLL;
using Monitor.Component.Model;

namespace Monitor.Manager.DormForm
{
	public partial class SaveDormAdmin : Form
	{
		public Guid AdminID { get; set; }
		private DormAdmin oDormAdmin = new DormAdmin( );

		public SaveDormAdmin ( )
		{
			InitializeComponent( );
		}

		private void LoadBase ( )
		{
			List<Dorm> oList = DormManager.GetAllDormWithList( );
			oList.Insert( 0 , new Dorm( ) { DormID = Guid.Empty , DormNumber = "请选择" } );

			cmbDormList.ValueMember = "DormID";
			cmbDormList.DisplayMember = "DormNumber";
			cmbDormList.DataSource = oList;
		}

		private void LoadData ( )
		{
			if ( AdminID == Guid.Empty )
			{
				return;
			}

			oDormAdmin = DormAdminManager.GetDormAdmins( AdminID );

			if ( oDormAdmin == null )
			{
				MessageBox.Show( "未找到指定的公寓管理员信息" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Error );

				return;
			}
			this.Text = labTitle.Text = "编辑公寓管理员信息";

			txtAdminName.TextValue = oDormAdmin.AdminName;
			txtMobile.TextValue = oDormAdmin.Mobile;
			txtRemark.TextValue = oDormAdmin.Remark;

			cmbDormList.SelectedValue = oDormAdmin.DormID;
		}

		private void btnCancel_Click (object sender , EventArgs e)
		{
			this.Close( );
		}

		private void btnSubmit_Click (object sender , EventArgs e)
		{
			if ( txtAdminName.TextValue.Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请输入公寓管理员名称" );
				txtAdminName.Focus( );
				return;
			}

			if ( cmbDormList.SelectedValue == null || ( Guid )cmbDormList.SelectedValue == Guid.Empty )
			{
				CommonMethod.ShowWaringMessage( "请选择管理员所管理的公寓" );
				cmbDormList.Focus( );
				return;
			}



			oDormAdmin.AdminName = txtAdminName.TextValue;
			oDormAdmin.DormID = ( Guid )cmbDormList.SelectedValue;
			oDormAdmin.Mobile = txtMobile.TextValue;
			oDormAdmin.Remark = txtRemark.TextValue;
			var server = ServerManager.GetServerByDormID( oDormAdmin.DormID );

			if ( oDormAdmin.DormAdmins == Guid.Empty )
			{
				oDormAdmin.DormAdmins = Guid.NewGuid( );
				oDormAdmin.AddDate = DateTime.Now;
				oDormAdmin.IsDeleted = false;
			}

			if ( DormAdminManager.SaveDormAdmins( oDormAdmin , server.Connection ) )
			{
				if ( AdminID == Guid.Empty )
				{
					if ( DialogResult.Yes == MessageBox.Show( "信息提交成功,是否继续添加公寓管理没" , "提示" , MessageBoxButtons.YesNo , MessageBoxIcon.Information ) )
					{
						oDormAdmin = new DormAdmin( );
						txtAdminName.TextValue = txtMobile.TextValue = txtRemark.TextValue = string.Empty;
						cmbDormList.SelectedIndex = 1;
						txtAdminName.Focus( );
					}
					else
					{
						this.Close( );
					}
				}
				else
				{
					MessageBox.Show( "信息提交成功" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );
					this.Close( );
				}
			}
			else
			{
				MessageBox.Show( "信息提交失败，请重试。\r\n\r\n如果能在列表页看到你添回的管理员信息，\r\n则失败原因是更新当前管理员信息到指定的管户端没有成功。\r\n\r\n请试着修改添加的信息。" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );
			}
		}

		private void SaveDormAdmin_Load (object sender , EventArgs e)
		{
			LoadBase( );

			LoadData( );
		}
	}
}
