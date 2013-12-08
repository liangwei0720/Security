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
	public class ClassesData : DataExecute
	{
		/// <summary>
		/// 得到一个班级信息
		/// </summary>
		/// <param name="GuidClassID"></param>
		/// <returns></returns>
		public static DataTable GetClasses(Guid GuidClassID)
		{
			string strStoreProcedure = "GetClasses";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guClassID", System.Data.DbType.Guid, GuidClassID);

			return osdDataBase.ExecuteDataSet(odbCommand).Tables[0];
		}

		/// <summary>
		/// 删除班级信息
		/// </summary>
		/// <param name="GuidClassID"></param>
		/// <returns></returns>
		public static int DeleteClasses(Guid GuidClassID)
		{
			string strStoreProcedure = "DeleteClasses";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guClassID", System.Data.DbType.Guid, GuidClassID);

			return osdDataBase.ExecuteNonQuery(odbCommand);
		}

		/// <summary>
		/// 保存班级信息
		/// </summary>
		/// <param name="oClasses"></param>
		/// <returns></returns>
		public static int SaveClasses(Classes oClasses)
		{
			string strStoreProcedure = "SaveClasses";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@guClassID", System.Data.DbType.Guid, oClasses.ClassID);
			osdDataBase.AddInParameter(odbCommand, "@nvcClassName", System.Data.DbType.String, oClasses.ClassName);
			osdDataBase.AddInParameter(odbCommand, "@bIsDeleted", System.Data.DbType.Boolean, oClasses.IsDeleted);
			osdDataBase.AddInParameter(odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oClasses.AddDate);
			osdDataBase.AddInParameter(odbCommand, "@nvcRemark", System.Data.DbType.String, oClasses.Remark);
			osdDataBase.AddInParameter(odbCommand, "@guFacultyID", System.Data.DbType.Guid, oClasses.FacultyID);

			return osdDataBase.ExecuteNonQuery(odbCommand);

		}

	}
}
