using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component.Model;
using Monitor.Component.BLL;

namespace Monitor.Manager.DormForm
{
	public partial class DormAdminList : Form
	{
		public List<DormAdmin> oDormAdmins = new List<DormAdmin>( );
		List<Dorm> oListDorm = new List<Dorm>( );

		public DormAdminList ( )
		{
			InitializeComponent( );
		}

		private void LoadData ( )
		{
			oListDorm = DormManager.GetAllDormWithList( );

			oDormAdmins = DormAdminManager.GetAllDormAdmins( string.Empty );

			//更改当前的管理所在公寓的信息
			oDormAdmins.ForEach( info => info.AdminName = string.Format( "{0}  [{1}]" , info.AdminName , ( oListDorm.Find( dorm => dorm.DormID == info.DormID ) ?? new Dorm { DormNumber = "未找到" } ).DormNumber ) );

			dgList.AutoGenerateColumns = false;
			dgList.DataSource = oDormAdmins;
		}

		private void btnSearch_Click (object sender , EventArgs e)
		{
			if ( txtSearch.TextValue.Length == 0 )
			{
				this.LoadData( );
				return;
			}

			dgList.DataSource = oDormAdmins.FindAll( info => info.AdminName.Equals( txtSearch.TextValue , StringComparison.OrdinalIgnoreCase ) );
		}

		private void btnAdd_Click (object sender , EventArgs e)
		{
			SaveDormAdmin oSaveDor = new SaveDormAdmin( );

			oSaveDor.ShowDialog( );

			this.LoadData( );
		}

		private void btnEdit_Click (object sender , EventArgs e)
		{
			if ( !CheckSelectedItems )
			{
				MessageBox.Show( "请选择要编辑的项" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
				return;
			}

			Guid adminID = Guid.Empty;

			foreach ( DataGridViewRow row in dgList.Rows )
			{
				if ( row.Cells["tcCheck"].Value != null )
				{
					adminID = ( Guid )row.Cells["tcDormAdminID"].Value;
					break;
				}
			}

			SaveDormAdmin oSaveDor = new SaveDormAdmin { AdminID = adminID };

			oSaveDor.ShowDialog( );

			this.LoadData( );
		}

		private void btnDel_Click (object sender , EventArgs e)
		{
			if ( !CheckSelectedItems )
			{
				MessageBox.Show( "请选择要删除的项" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
				return;
			}

			if ( DialogResult.No == MessageBox.Show( "确定要删除所选的信息吗？" , "警告" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning ) )
			{
				return;
			}
			string alertMsg = "所选信息已全部删除";
			foreach ( DataGridViewRow row in dgList.Rows )
			{
				if ( row.Cells["tcCheck"].Value != null )
				{
					var server =ServerManager.GetServerByDormID( ( Guid )row.Cells["tcDormID"].Value );
					if ( !DormAdminManager.DeleteDormAdmins( ( Guid )row.Cells["tcDormAdminID"].Value , server.Connection ) )
					{
						alertMsg = "删除信息失败，请稍候再试";
						break;
					}
				}
			}

			MessageBox.Show( alertMsg , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );

		}

		private void DormAdminList_Load (object sender , EventArgs e)
		{
			this.LoadData( );
		}

		private void dgList_CellDoubleClick (object sender , DataGridViewCellEventArgs e)
		{
			if ( e.RowIndex < 0 )
			{
				return;
			}

			SaveDormAdmin oSaveForm = new SaveDormAdmin { AdminID = ( Guid )dgList.CurrentRow.Cells["tcDormAdminID"].Value };
			oSaveForm.ShowDialog( );

			this.LoadData( );
		}

		private bool CheckSelectedItems
		{
			get
			{
				bool blSelected = false;
				foreach ( DataGridViewRow row in dgList.Rows )
				{
					if ( row.Cells["tcCheck"].Value != null && ( bool )row.Cells["tcCheck"].Value )
					{
						blSelected = true;
						break;
					}
				}
				return blSelected;
			}
		}
	}
}
