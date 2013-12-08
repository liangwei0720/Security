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

namespace Monitor.Manager.UpdateInfoForm
{
	public partial class UpdateDormToClient : Form
	{
		private List<Component.Model.Server> oListServer = ServerManager.GetAllServer( );
		private List<Component.Model.Dorm> oListDorm = DormManager.GetAllDormWithList( );
		private List<Component.Model.DormRooms> oListRoom = DormRoomManager.GetAllDormRooms( );

		public UpdateDormToClient ( )
		{
			InitializeComponent( );
		}

		private void UpdateDormToClient_Load (object sender , EventArgs e)
		{

			BindDataGridView( );

			oListServer.Insert( 0 , new Component.Model.Server( ) { ServerName = "全部" , Connection = string.Empty , GuDormID = Guid.Empty } );
			comboxClient.DisplayMember = "ServerName";
			comboxClient.ValueMember = "Connection";
			comboxClient.DataSource = oListServer;


			oListDorm.Insert( 0 , new Component.Model.Dorm { DormID = Guid.Empty , DormNumber = "全部" } );
			comboxDorm.ValueMember = "DormID";
			comboxDorm.DisplayMember = "DormNumber";
			comboxDorm.DataSource = oListDorm;
		}

		private void BindDataGridView ( )
		{
			var oDataSource = from dorm in oListDorm
							  from dormRoom in oListRoom
							  where dormRoom.DormID == dorm.DormID
							  select new { DormNumber = dorm.DormNumber , RoomNumber = dormRoom.RoomNumber , DormID = dormRoom.DormID };

			if ( comboxDorm.SelectedValue != null && ( ( Dorm )comboxDorm.SelectedItem ).DormID != Guid.Empty )
			{
				var dataSouceForSeach = oDataSource.Where( info => info.DormID == ( ( Dorm )comboxDorm.SelectedItem ).DormID );
				dgList.DataSource = dataSouceForSeach.ToList( );
			}
			else
			{
				dgList.DataSource = oDataSource.ToList( );
			}

			btnAddToDB.Visible = dgList.RowCount > 0;
		}

		private void btnOk_Click (object sender , EventArgs e)
		{
			BindDataGridView( );
		}

		private void btnAddToDB_Click (object sender , EventArgs e)
		{
			if ( DialogResult.Cancel == MessageBox.Show( "更新数据中，有可能界面无响应，请等待。\r\n确定要执行更新吗？" , "提示" , MessageBoxButtons.OKCancel , MessageBoxIcon.Information ) )
			{
				return;
			}
			bool success = true;
			//选择信息更新到指定的客户端
			if ( comboxClient.SelectedItem != null && ( ( Server )comboxClient.SelectedItem ).GuDormID != Guid.Empty )
			{
				var server = ( Server )comboxClient.SelectedItem;

				var dorms = GetDormRooms( );

				foreach ( Dorm dorm in dorms )
				{
					if ( !success )
					{
						break;
					}

					if ( !DormManager.SaveDorm( dorm , server.Connection ) )
					{
						success = false;
						break;
					}

					var rooms = oListRoom.FindAll( room => room.DormID == dorm.DormID );

					//更新宿舍信息到客户端
					foreach ( DormRooms room in rooms )
					{
						if ( room.RoomID == Guid.Empty )
						{
							continue;
						}

						if ( !DormRoomManager.SaveDormRooms( room , server.Connection ) )
						{
							success = false;
							break;
						}
					}
				}
			}
			else
			{
				//更新所有的客户端信息
				foreach ( Dorm dorm in oListDorm )
				{
					if ( !success )
					{
						break;
					}

					if ( dorm.DormID == Guid.Empty )
					{
						continue;
					}

					foreach ( Server server in oListServer )
					{
						if ( server.GuDormID == Guid.Empty )
						{
							continue;
						}

						if ( !DormManager.SaveDorm( dorm , server.Connection ) )
						{
							success = false;
							break;
						}

						var rooms = oListRoom.FindAll( room => room.DormID == dorm.DormID );

						//更新宿舍信息到客户端
						foreach ( DormRooms room in rooms )
						{
							if ( room.RoomID == Guid.Empty )
							{
								continue;
							}
							if ( !DormRoomManager.SaveDormRooms( room , server.Connection ) )
							{
								success = false;
								break;
							}
						}
					}
				}

			}

			if ( success )
			{
				MessageBox.Show( "信息更新成功" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );
			}
			else
			{
				MessageBox.Show( "信息更新失败，请稍候再试。" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );
			}

		}

		private List<Dorm> GetDormRooms ( )
		{
			if ( comboxDorm.SelectedValue != null && ( ( Dorm )comboxDorm.SelectedItem ).DormID != Guid.Empty )
			{
				return oListDorm.FindAll( dorm => dorm.DormID == ( ( Dorm )comboxDorm.SelectedItem ).DormID );
			}

			return oListDorm;

		}

	}
}
