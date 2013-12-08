using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
	public class SchoolManager
	{
		/// <summary>
		/// 获取学校的信息
		/// </summary>
		/// <param name="GuidSchoolID"></param>
		/// <returns></returns>
		public static Schools GetSchools(Guid GuidSchoolID)
		{
			DataTable dt = SchoolsData.GetSchools(GuidSchoolID);

			if ( dt.Rows.Count == 0 )
			{
				return null;
			}

			return ParseSchools(dt.Rows[0]);

		}

		/// <summary>
		/// 删除学校的基本信息
		/// </summary>
		/// <param name="GuidSchoolID"></param>
		public static void DeleteSchools(Guid GuidSchoolID)
		{
			SchoolsData.DeleteSchools(GuidSchoolID);
		}
		/// <summary>
		/// 保存学校的基本信息
		/// </summary>
		/// <param name="oSchools"></param>
		public static bool SaveSchools(Schools oSchools)
		{
			return SchoolsData.SaveSchools(oSchools)>0;

		}

		/// <summary>
		/// 解析实体
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		private static Schools ParseSchools(DataRow row)
		{
			Schools oSchools = new Schools( );
			oSchools.SchoolID = row["guSchoolID"] is DBNull ? Guid.Empty : ( Guid )row["guSchoolID"];
			oSchools.SchoolName = row["nvcSchoolName"] is DBNull ? "" : ( string )row["nvcSchoolName"];
			oSchools.SchoolCode = row["nvcSchoolCode"] is DBNull ? "" : ( string )row["nvcSchoolCode"];
			oSchools.SchoolCampus = row["nvcSchoolCampus"] is DBNull ? "" : ( string )row["nvcSchoolCampus"];
			oSchools.SchoolSummary = row["nvcSchoolSummary"] is DBNull ? "" : ( string )row["nvcSchoolSummary"];
			oSchools.Remark = row["nvcRemark"] is DBNull ? "" : ( string )row["nvcRemark"];
			oSchools.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )row["dtAddDate"];
			oSchools.IsDeleted = row["bIsDeleted"] is DBNull ? false : ( bool )row["bIsDeleted"];

			return oSchools;

		}
	}
}
