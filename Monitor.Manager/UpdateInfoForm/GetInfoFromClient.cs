using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component.BLL;
using System.Web.UI.WebControls;
using Monitor.Component.Model;

namespace Monitor.Manager.UpdateInfoForm
{
	public partial class GetInfoFromClient : Form
	{
		private List<Component.Model.Server> oListServer = ServerManager.GetAllServer( );

		private List<InOutInfo> oList = new List<InOutInfo>( );

		private List<ErrorLog> oListErrorLog = new List<ErrorLog>( );

		private bool IsInOutInfo = false;

		public GetInfoFromClient ( )
		{
			InitializeComponent( );
		}

		private void GetInfoFromClient_Load (object sender , EventArgs e)
		{
			oListServer.Insert( 0 , new Component.Model.Server( ) { ServerName = "全部" , Connection = string.Empty } );
			comboxClient.DisplayMember = "ServerName";
			comboxClient.ValueMember = "Connection";
			comboxClient.DataSource = oListServer;

			//comboxType.Items.Add (new ListItem ("全部", ""));
			//comboxType.Items.Add (new ListItem ("出入记录", "出入记录"));
			//comboxType.Items.Add (new ListItem ("日志", "日志"));
			comboxType.SelectedIndex = 0;
		}

		private void btnOk_Click (object sender , EventArgs e)
		{
			if ( comboxType.SelectedItem.ToString( ) == "出入记录" )
			{
				oList = new List<InOutInfo>( );
				dgErrorList.Visible = false;
				IsInOutInfo = true;
				GetInOutInfo( );
			}
			else
			{
				oListErrorLog = new List<ErrorLog>( );
				dgList.Visible = false;
				IsInOutInfo = false;
				GetErrorLogInfo( );
			}
		}

		private void GetErrorLogInfo ( )
		{
			if ( comboxClient.SelectedValue.ToString( ) != "" )
			{
				var serverModel = comboxClient.SelectedItem as Server;

				oListErrorLog = ErrorLogManager.GetErrorLog( string.Empty , comboxClient.SelectedValue.ToString( ) );
				oListErrorLog.ForEach( info => info.DormID = serverModel.GuDormID );
			}
			else
			{
				List<ErrorLog> oListSub = new List<ErrorLog>( );
				foreach ( Server _item in comboxClient.Items )
				{
					if ( _item.Connection != "" )
					{
						oListSub = ErrorLogManager.GetErrorLog( string.Empty , _item.Connection );
						oListSub.ForEach( info =>
						{
							info.DormID = _item.GuDormID;
						} );
						oListErrorLog.AddRange( oListSub );
					}
				}
			}

			dgErrorList.AutoGenerateColumns = false;
			dgErrorList.DataSource = oList;
			dgErrorList.Visible = true;
			btnAddToDB.Visible = oListErrorLog.Count > 0;
		}

		private void GetInOutInfo ( )
		{
			if ( comboxClient.SelectedValue.ToString( ) != "" )
			{
				var serverModel = comboxClient.SelectedItem as Server;
				oList = InOutInfoManager.GetListByCondition( string.Empty , comboxClient.SelectedValue.ToString( ) );
				oList.ForEach( info => info.DormID = serverModel.GuDormID );
			}
			else
			{

				List<InOutInfo> oListSub = new List<InOutInfo>( );
				foreach ( Server _item in comboxClient.Items )
				{
					if ( _item.Connection != "" )
					{
						oListSub = InOutInfoManager.GetListByCondition( string.Empty , _item.Connection );
						oListSub.ForEach( info =>
						{
							info.DormID = _item.GuDormID;
							info.DormName = _item.ServerName;
							info.GUInOutID = Guid.NewGuid( );
						} );
						oList.AddRange( oListSub );
					}
				}
			}
			dgList.Visible = true;
			dgList.AutoGenerateColumns = false;
			dgList.DataSource = oList;
			btnAddToDB.Visible = oList.Count > 0;
		}

		private void btnAddToDB_Click (object sender , EventArgs e)
		{
			if ( IsInOutInfo )
			{
				foreach ( InOutInfo info in oList )
				{
					//保存信息到数据库
					InOutInfoManager.SaveInOutInfo( info );
					//删除客户端数据
					InOutInfoManager.DeleteInOutInfo( info.InOutID , ( oListServer.Find( info1 => info1.GuDormID == info.DormID ) ?? new Server( ) { Connection = string.Empty } ).Connection );
				}

			}
			else
			{
				foreach ( ErrorLog oErrorInfo in oListErrorLog )
				{
					ErrorLogManager.SaveErrorLog( oErrorInfo );
					ErrorLogManager.DeleteErrorLog( oErrorInfo.ID , ( oListServer.Find( info1 => info1.GuDormID == oErrorInfo.DormID ) ?? new Server( ) { Connection = string.Empty } ).Connection );
				}
			}

			CommonMethod.ShowWaringMessage( "获取的信息已导入数据库。" );
		}
	}
}
