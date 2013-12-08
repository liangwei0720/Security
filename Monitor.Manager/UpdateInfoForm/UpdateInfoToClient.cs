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

namespace Monitor.Manager.UpdateInfoForm
{
	public partial class UpdateInfoToClient : Form
	{
		#region 变量
		private List<Students> oList = new List<Students>( );
		private List<Dorm> oListDorm = DormManager.GetAllDormWithList( );
		private DataTable oTableRoom = DormRoomManager.GetDormRoomsByCondtion( string.Empty );

		private List<Server> oListServer = ServerManager.GetAllServer( );
		#endregion

		public UpdateInfoToClient ( )
		{
			InitializeComponent( );
			this.dgStudentsList.AutoGenerateColumns = false;
		}

		private void btnOk_Click (object sender , EventArgs e)
		{
			string strCondtion = string.Empty;

            if (txtStudentName.TextValue.Length > 0)
			{
				strCondtion = string.Format( "nvcStudentName='{0}'" , txtStudentName.TextValue.Replace( "'" , "" ) );
			}
			if ( txtStudentNumber.TextValue.Length > 0 )
			{
				strCondtion = string.Format( "{0} {1}nvcStudentNumber='{2}'" , strCondtion , strCondtion.Length > 0 ? "AND " : string.Empty , txtStudentNumber.TextValue.Replace( "'" , "" ) );
			}
			if ( txtSpecialty.TextValue.Length > 0 )
			{
				strCondtion = string.Format( "{0} {1}nvcSpecialty='{2}'" , strCondtion , strCondtion.Length > 0 ? "AND " : string.Empty , txtSpecialty.TextValue.Replace( "'" , "" ) );
			}

			if ( txtClassName.TextValue.Length > 0 )
			{
				strCondtion = string.Format( "{0} {1}nvcClassName='{2}'" , strCondtion , strCondtion.Length > 0 ? "AND " : string.Empty , txtClassName.TextValue.Replace( "'" , "" ) );
			}

			oList = new StudentManager( ).GetAllStudents( strCondtion );

			dgStudentsList.DataSource = oList;


		}

		private void btnAddToClient_Click (object sender , EventArgs e)
		{
			try
			{
				foreach ( Students oStudent in oList )
				{

					var DormID = ( from DataRow dorm in oTableRoom.Select( "guRoomID='" + oStudent.RoomID + "'" ).AsEnumerable( )
								   select dorm.Field<Guid>( "guDormID" ) ).First( );


					new StudentManager( ).AddStudent( oStudent , oListServer.Find( info => info.GuDormID == DormID ).Connection );
				}

				MessageBox.Show( "已成功将当前信息更新到相应的客户端" , "提示" , MessageBoxButtons.OK , MessageBoxIcon.Information );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "出错了。错误信息：" + ex.Message , "警告" , MessageBoxButtons.OK , MessageBoxIcon.Error );
			}
		}
	}
}
