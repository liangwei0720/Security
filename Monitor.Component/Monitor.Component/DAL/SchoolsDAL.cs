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
	public class SchoolsData : DataExecute
	{
		/// <summary>
		/// 获取学校的信息
		/// </summary>
		/// <param name="GuidSchoolID"></param>
		/// <returns></returns>
		public static DataTable GetSchools(Guid GuidSchoolID)
		{
			string strStoreProcedure = "GetSchools";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guSchoolID", System.Data.DbType.Guid, GuidSchoolID);

			return osdDataBase.ExecuteDataSet(odbCommand).Tables[0];

		}

		/// <summary>
		/// 删除学校的基本信息
		/// </summary>
		/// <param name="GuidSchoolID"></param>
		public static void DeleteSchools(Guid GuidSchoolID)
		{
			string strStoreProcedure = "DeleteSchools";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guSchoolID", System.Data.DbType.Guid, GuidSchoolID);

			osdDataBase.ExecuteNonQuery(odbCommand);
		}
		/// <summary>
		/// 保存学校的基本信息
		/// </summary>
		/// <param name="oSchools"></param>
		public static int SaveSchools(Schools oSchools)
		{
			string strStoreProcedure = "SaveSchools";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guSchoolID", System.Data.DbType.Guid, oSchools.SchoolID);
			osdDataBase.AddInParameter(odbCommand, "@nvcSchoolName", System.Data.DbType.String, oSchools.SchoolName);
			osdDataBase.AddInParameter(odbCommand, "@nvcSchoolCode", System.Data.DbType.String, oSchools.SchoolCode);
			osdDataBase.AddInParameter(odbCommand, "@nvcSchoolCampus", System.Data.DbType.String, oSchools.SchoolCampus);
			osdDataBase.AddInParameter(odbCommand, "@nvcSchoolSummary", System.Data.DbType.String, oSchools.SchoolSummary);
			osdDataBase.AddInParameter(odbCommand, "@nvcRemark", System.Data.DbType.String, oSchools.Remark);
			osdDataBase.AddInParameter(odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oSchools.AddDate);
			osdDataBase.AddInParameter(odbCommand, "@bIsDeleted", System.Data.DbType.Boolean, oSchools.IsDeleted);

			return osdDataBase.ExecuteNonQuery(odbCommand);

		}

	}
}
