using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;


namespace Monitor.Component.DAL
{
	public class DormRoomsData : DataExecute
	{
		/// <summary>
		/// 获取一个宿舍信息
		/// </summary>
		/// <param name="GuidRoomID"></param>
		/// <returns></returns>
		public static DataTable GetDormRooms (Guid GuidRoomID)
		{
			string strStoreProcedure = "GetDormRooms";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guRoomID" , System.Data.DbType.Guid , GuidRoomID );

			return osdDataBase.ExecuteDataSet( odbCommand ).Tables[0];
		}

		/// <summary>
		/// 删除一个宿舍信息
		/// </summary>
		/// <param name="GuidRoomID"></param>
		/// <returns></returns>
		public static int DeleteDormRooms (Guid GuidRoomID)
		{
			string strStoreProcedure = "DeleteDormRooms";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guRoomID" , System.Data.DbType.Guid , GuidRoomID );

			return osdDataBase.ExecuteNonQuery( odbCommand );
		}

		/// <summary>
		/// 保存宿舍信息
		/// </summary>
		/// <param name="oDormRooms"></param>
		public static int SaveDormRooms (DormRooms oDormRooms)
		{
			string strStoreProcedure = "SaveDormRooms";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guRoomID" , System.Data.DbType.Guid , oDormRooms.RoomID );
			osdDataBase.AddInParameter( odbCommand , "@nvcRoomNumber" , System.Data.DbType.String , oDormRooms.RoomNumber );
			osdDataBase.AddInParameter( odbCommand , "@bIsDeleted" , System.Data.DbType.Boolean , oDormRooms.IsDeleted );
			osdDataBase.AddInParameter( odbCommand , "@dtAddDate" , System.Data.DbType.DateTime , oDormRooms.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@nvcRemark" , System.Data.DbType.String , oDormRooms.Remark );
			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , oDormRooms.DormID );

			return osdDataBase.ExecuteNonQuery( odbCommand );

		}

		/// <summary>
		/// 保存宿舍信息
		/// </summary>
		/// <param name="oDormRooms"></param>
		public static int SaveDormRooms (DormRooms oDormRooms , string SqlConnectionString)
		{
			string strStoreProcedure = "SaveDormRooms";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guRoomID" , System.Data.DbType.Guid , oDormRooms.RoomID );
			osdDataBase.AddInParameter( odbCommand , "@nvcRoomNumber" , System.Data.DbType.String , oDormRooms.RoomNumber );
			osdDataBase.AddInParameter( odbCommand , "@bIsDeleted" , System.Data.DbType.Boolean , oDormRooms.IsDeleted );
			osdDataBase.AddInParameter( odbCommand , "@dtAddDate" , System.Data.DbType.DateTime , oDormRooms.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@nvcRemark" , System.Data.DbType.String , oDormRooms.Remark );
			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , oDormRooms.DormID );

			return osdDataBase.ExecuteNonQuery( odbCommand );

		}

		/// <summary>
		/// 根据查询条件获取一个宿舍信息
		/// </summary>
		/// <param name="GuidRoomID"></param>
		/// <returns></returns>
		public static DataTable GetDormRoomsByCondtion (string condition)
		{
			string strSQL = "SELECT * FROM DormRooms WHERE " + condition;

			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetSqlStringCommand( strSQL );

			return osdDataBase.ExecuteDataSet( odbCommand ).Tables[0];
		}

	}
}
