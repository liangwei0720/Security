using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

namespace Monitor.Component.DAL
{
	public class DormData : DataExecute
	{
		/// <summary>
		/// 得到一个公寓信息
		/// </summary>
		/// <param name="GuidDormID"></param>
		/// <returns></returns>
		public static DataTable GetDorm (Guid GuidDormID)
		{
			string strStoreProcedure = "GetDorm";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , GuidDormID );

			return osdDataBase.ExecuteDataSet( odbCommand ).Tables[0];

		}
		/// <summary>
		/// 删除一个公寓信息
		/// </summary>
		/// <param name="GuidDormID"></param>
		public static int DeleteDorm (Guid GuidDormID)
		{
			string strStoreProcedure = "DeleteDorm";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , GuidDormID );

			return osdDataBase.ExecuteNonQuery( odbCommand );
		}

		/// <summary>
		/// 保存公寓信息
		/// </summary>
		/// <param name="oDorm"></param>
		public static int SaveDorm (Dorm oDorm)
		{
			string strStoreProcedure = "SaveDorm";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , oDorm.DormID );
			osdDataBase.AddInParameter( odbCommand , "@nvcDormNumber" , System.Data.DbType.String , oDorm.DormNumber );
			osdDataBase.AddInParameter( odbCommand , "@iFlools" , System.Data.DbType.Int16 , oDorm.Flools );
			osdDataBase.AddInParameter( odbCommand , "@nvcRemark" , System.Data.DbType.String , oDorm.Remark );
			osdDataBase.AddInParameter( odbCommand , "@dtAddDate" , System.Data.DbType.DateTime , oDorm.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@guSchoolID" , System.Data.DbType.Guid , oDorm.SchoolID );
			osdDataBase.AddInParameter( odbCommand , "@bIsDeleted" , System.Data.DbType.Boolean , oDorm.IsDeleted );

			return osdDataBase.ExecuteNonQuery( odbCommand );

		}

		/// <summary>
		/// 保存公寓信息
		/// </summary>
		/// <param name="oDorm"></param>
		public static int SaveDorm (Dorm oDorm , string SqlConnectionString)
		{
			string strStoreProcedure = "SaveDorm";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , oDorm.DormID );
			osdDataBase.AddInParameter( odbCommand , "@nvcDormNumber" , System.Data.DbType.String , oDorm.DormNumber );
			osdDataBase.AddInParameter( odbCommand , "@iFlools" , System.Data.DbType.Int16 , oDorm.Flools );
			osdDataBase.AddInParameter( odbCommand , "@nvcRemark" , System.Data.DbType.String , oDorm.Remark );
			osdDataBase.AddInParameter( odbCommand , "@dtAddDate" , System.Data.DbType.DateTime , oDorm.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@guSchoolID" , System.Data.DbType.Guid , oDorm.SchoolID );
			osdDataBase.AddInParameter( odbCommand , "@bIsDeleted" , System.Data.DbType.Boolean , oDorm.IsDeleted );

			return osdDataBase.ExecuteNonQuery( odbCommand );

		}

		/// <summary>
		/// 得到一个公寓信息
		/// </summary>
		/// <param name="GuidDormID"></param>
		/// <returns></returns>
		public static DataTable GetAllDorm ( )
		{
			string strStoreProcedure = "GetAllDorm";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			return osdDataBase.ExecuteDataSet( odbCommand ).Tables[0];

		}

	}
}

