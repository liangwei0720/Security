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
	public class FacultiesData : DataExecute
	{
		/// <summary>
		/// 获取一个院系信息
		/// </summary>
		/// <param name="GuidFacultyID"></param>
		/// <returns></returns>
		public static DataTable GetFaculties(Guid GuidFacultyID)
		{
			string strStoreProcedure = "GetFaculties";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guFacultyID", System.Data.DbType.Guid, GuidFacultyID);

			return osdDataBase.ExecuteDataSet(odbCommand).Tables[0];
		}
		/// <summary>
		/// 删除一个院系
		/// </summary>
		/// <param name="GuidFacultyID"></param>
		/// <returns></returns>
		public static int DeleteFaculties(Guid GuidFacultyID)
		{
			string strStoreProcedure = "DeleteFaculties";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guFacultyID", System.Data.DbType.Guid, GuidFacultyID);

			return osdDataBase.ExecuteNonQuery(odbCommand);
		}

		/// <summary>
		/// 保存院系信息
		/// </summary>
		/// <param name="oFaculties"></param>
		public static int SaveFaculties(Faculties oFaculties)
		{
			string strStoreProcedure = "SaveFaculties";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guFacultyID", System.Data.DbType.Guid, oFaculties.FacultyID);
			osdDataBase.AddInParameter(odbCommand, "@nvcFacultyName", System.Data.DbType.String, oFaculties.FacultyName);
			osdDataBase.AddInParameter(odbCommand, "@bIsDeleted", System.Data.DbType.Boolean, oFaculties.IsDeleted);
			osdDataBase.AddInParameter(odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oFaculties.AddDate);
			osdDataBase.AddInParameter(odbCommand, "@nvcRemark", System.Data.DbType.String, oFaculties.Remark);
			osdDataBase.AddInParameter(odbCommand, "@guSchoolID", System.Data.DbType.Guid, oFaculties.SchoolID);

			return osdDataBase.ExecuteNonQuery(odbCommand);

		}

		/// <summary>
		/// 获取一个院系信息
		/// </summary>
		/// <param name="GuidFacultyID"></param>
		/// <returns></returns>
		public static DataTable GetAllFaculties( )
		{
			string strStoreProcedure = "GetAllFaculties";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			return osdDataBase.ExecuteDataSet(odbCommand).Tables[0];
		}

	}
}
