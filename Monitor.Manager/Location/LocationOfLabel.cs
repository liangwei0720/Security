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

namespace Monitor.Manager.Location
{
	public partial class LocationOfLabel : Form
	{
		List<Labels> oListLabels=new List<Labels>( );

		public LocationOfLabel ( )
		{
			InitializeComponent( );

			oListLabels = LabelManager.GetLabelsByCondition( "" );
		}

		private void btnSearch_Click (object sender , EventArgs e)
		{
			if ( oListLabels == null || oListLabels.Count == 0 )
			{
				CommonMethod.ShowWaringMessage( "未找到标签信息，请确认系统里是否已录入标签信息" );

				return;
			}

			if ( txtLabelName.TextValue.Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请输入标签信息" );

				return;
			}
			//检测当前的标签信息是否正确
			var label = LabelManager.GetLabels( txtLabelName.TextValue );

			if ( label == null || label.Status == ( int )Monitor.Component.StaticValue.LabelStatus.已损坏 )
			{
				CommonMethod.ShowWaringMessage( string.Format( "未找到 {0} 的标签信息或此标签信息已标记为“已损坏”，请确认你输入的标签名称是正确。" , txtLabelName.TextValue ) );

				return;
			}
			//检测标签的状态
			if ( label.Status != ( int )Monitor.Component.StaticValue.LabelStatus.已分配 )
			{
				CommonMethod.ShowWaringMessage( string.Format( "{0} 的标签信息为{1}。如有问题请联系管理员。" , txtLabelName.TextValue , ( Monitor.Component.StaticValue.LabelStatus )label.Status ) );

				return;
			}
			//查找标签对应的物品
			var goods = new GoodsManager( ).GetGoodsByLabelNumber( txtLabelName.TextValue );

			if ( goods == null )
			{
				CommonMethod.ShowWaringMessage( string.Format( "未找到 {0} 的标签所对应的物品信息，请确认你输入的标签名称是正确。\r\n如有问题请联系管理员。" , txtLabelName.TextValue ) );

				return;
			}
			//查找物品对应的学生信息
			var students = new StudentManager( ).GetStudent( goods.StudentNumber );
			if ( students == null )
			{
				CommonMethod.ShowWaringMessage( string.Format( "未找到 {0} 的标签所分配的学生信息。\r\n如有问题请联系管理员。" , txtLabelName.TextValue ) );

				return;
			}
			//查找学生所在公寓
			var room = DormRoomManager.GetDormRooms( students.RoomID );

			if ( room == null )
			{
				CommonMethod.ShowWaringMessage( string.Format( "未找到 {0} 的标签所分配的学生所在宿舍信息。\r\n如有问题请联系管理员。" , txtLabelName.TextValue ) );

				return;
			}
			//查找该公寓的监控机器的IP地址
			var serverInfo = ServerManager.GetServerByDormID( room.DormID );
			if ( serverInfo == null )
			{
				CommonMethod.ShowWaringMessage( string.Format( "未找到 {0} 的标签所分配的学生公寓信息。\r\n如有问题请联系管理员。" , txtLabelName.TextValue ) );

				return;
			}
			try
			{
				//开始从客户端获取定位信息
				var historyList = T_MonitorHistoryManager.GetAllT_MonitorHistoryForLocation( " AND LabelMac='" + txtLabelName.TextValue + "'" , serverInfo.Connection );
				//匹配标签地址信息
				
			}
			catch ( Exception ex )
			{
				CommonMethod.ShowWaringMessage( "出错了,错误信息如下：" + ex.Message );
			}
		}
	}
}
