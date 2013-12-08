using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;
using Monitor.Component.Model;

namespace Monitor.Component.DAL
{
	public class DormAdminsData : DataExecute
	{
		/// <summary>
		/// 获取一个公寓管理员信息
		/// </summary>	
		/// <param name="GuidDormAdmins"></param>
		/// <returns></returns>
		public static DataTable GetDormAdmins (Guid GuidDormAdmins)
		{
			string strStoreProcedure = "GetDormAdmins";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormAdmins" , System.Data.DbType.Guid , GuidDormAdmins );

			return osdDataBase.ExecuteDataSet( odbCommand ).Tables[0];
		}

		/// <summary>
		/// 删除一个公寓管理员
		/// </summary>
		/// <param name="GuidDormAdmins"></param>
		public static int DeleteDormAdmins (Guid GuidDormAdmins)
		{
			string strStoreProcedure = "DeleteDormAdmins";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormAdmins" , System.Data.DbType.Guid , GuidDormAdmins );

			return osdDataBase.ExecuteNonQuery( odbCommand );
		}

		/// <summary>
		/// 删除一个公寓管理员
		/// </summary>
		/// <param name="GuidDormAdmins"></param>
		public static int DeleteDormAdmins (Guid GuidDormAdmins , string SqlConnectionString)
		{
			string strStoreProcedure = "DeleteDormAdmins";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormAdmins" , System.Data.DbType.Guid , GuidDormAdmins );

			return osdDataBase.ExecuteNonQuery( odbCommand );
		}
		/// <summary>
		/// 保存管理员信息
		/// </summary>
		/// <param name="oDormAdmins"></param>
		/// <returns></returns>
		public static int SaveDormAdmins (DormAdmin oDormAdmins)
		{
			string strStoreProcedure = "SaveDormAdmins";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormAdmins" , System.Data.DbType.Guid , oDormAdmins.DormAdmins );
			osdDataBase.AddInParameter( odbCommand , "@nvcAdminName" , System.Data.DbType.String , oDormAdmins.AdminName );
			osdDataBase.AddInParameter( odbCommand , "@nvcManangerFloor" , System.Data.DbType.String , oDormAdmins.ManangerFloor );
			osdDataBase.AddInParameter( odbCommand , "@vcMobile" , System.Data.DbType.String , oDormAdmins.Mobile );
			osdDataBase.AddInParameter( odbCommand , "@iStatus" , System.Data.DbType.Int32 , oDormAdmins.Status );
			osdDataBase.AddInParameter( odbCommand , "@nvcRemark" , System.Data.DbType.String , oDormAdmins.Remark );
			osdDataBase.AddInParameter( odbCommand , "@dtAddDate" , System.Data.DbType.DateTime , oDormAdmins.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , oDormAdmins.DormID );
			osdDataBase.AddInParameter( odbCommand , "@bIsDeleted" , System.Data.DbType.Boolean , oDormAdmins.IsDeleted );
			osdDataBase.AddInParameter( odbCommand , "@iCardNumber" , System.Data.DbType.Int32 , oDormAdmins.CardNumber == 0 ? null : oDormAdmins.CardNumber );

			return osdDataBase.ExecuteNonQuery( odbCommand );

		}

		/// <summary>
		/// 保存管理员信息
		/// </summary>
		/// <param name="oDormAdmins"></param>
		/// <returns></returns>
		public static int SaveDormAdmins (DormAdmin oDormAdmins , string sqlConnectionString)
		{
			string strStoreProcedure = "SaveDormAdmins";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormAdmins" , System.Data.DbType.Guid , oDormAdmins.DormAdmins );
			osdDataBase.AddInParameter( odbCommand , "@nvcAdminName" , System.Data.DbType.String , oDormAdmins.AdminName );
			osdDataBase.AddInParameter( odbCommand , "@nvcManangerFloor" , System.Data.DbType.String , oDormAdmins.ManangerFloor );
			osdDataBase.AddInParameter( odbCommand , "@vcMobile" , System.Data.DbType.String , oDormAdmins.Mobile );
			osdDataBase.AddInParameter( odbCommand , "@iStatus" , System.Data.DbType.Int32 , oDormAdmins.Status );
			osdDataBase.AddInParameter( odbCommand , "@nvcRemark" , System.Data.DbType.String , oDormAdmins.Remark );
			osdDataBase.AddInParameter( odbCommand , "@dtAddDate" , System.Data.DbType.DateTime , oDormAdmins.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , oDormAdmins.DormID );
			osdDataBase.AddInParameter( odbCommand , "@bIsDeleted" , System.Data.DbType.Boolean , oDormAdmins.IsDeleted );
			osdDataBase.AddInParameter( odbCommand , "@iCardNumber" , System.Data.DbType.Int32 , oDormAdmins.CardNumber == 0 ? null : oDormAdmins.CardNumber );

			return osdDataBase.ExecuteNonQuery( odbCommand );

		}

		/// <summary>
		/// 获取一个公寓管理员信息
		/// </summary>		
		/// <returns></returns>
		public static DataTable GetAllDormAdmins (string condition)
		{
			string strSqlText = "SELECT * FROM DormAdmins WHERE bIsDeleted = 0";

			if ( !string.IsNullOrEmpty( condition ) )
			{
				strSqlText += " AND " + condition;
			}
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetSqlStringCommand( strSqlText );

			return osdDataBase.ExecuteDataSet( odbCommand ).Tables[0];
		}

	}
}