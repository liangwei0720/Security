using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
	public class FacultiesManager
	{
		/// <summary>
		/// 获取一个院系信息
		/// </summary>
		/// <param name="GuidFacultyID"></param>
		/// <returns></returns>
		public static Faculties GetFaculties(Guid GuidFacultyID)
		{
			DataTable dt = FacultiesData.GetFaculties(GuidFacultyID);

			if ( dt.Rows.Count == 0 )
			{
				return null;
			}

			return ParseFaculties(dt.Rows[0]);
		}
		/// <summary>
		/// 删除一个院系
		/// </summary>
		/// <param name="GuidFacultyID"></param>
		/// <returns></returns>
		public static bool DeleteFaculties(Guid GuidFacultyID)
		{
			return FacultiesData.DeleteFaculties(GuidFacultyID) > 0;
		}

		/// <summary>
		/// 保存院系信息
		/// </summary>
		/// <param name="oFaculties"></param>
		public static int SaveFaculties(Faculties oFaculties)
		{
			return FacultiesData.SaveFaculties(oFaculties);

		}


		/// <summary>
		/// 获取所有院系信息
		/// </summary>
		/// <param name="GuidFacultyID"></param>
		/// <returns></returns>
		public static List<Faculties> GetAllFaculties()
		{
			DataTable dt = FacultiesData.GetAllFaculties();

			List<Faculties> olist = new List<Faculties>(dt.Rows.Count);

			if ( dt.Rows.Count > 0 )
			{
				foreach ( DataRow row in dt.Rows )
				{
					olist.Add(ParseFaculties(row));
				}
			}

			return olist;
		}

		/// <summary>
		/// 解析实体
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		private static Faculties ParseFaculties(DataRow row)
		{
			Faculties oFaculties = new Faculties( );

			oFaculties.FacultyID = row["guFacultyID"] is DBNull ? Guid.Empty : ( Guid )row["guFacultyID"];
			oFaculties.FacultyName = row["nvcFacultyName"] is DBNull ? "" : ( string )row["nvcFacultyName"];
			oFaculties.IsDeleted = row["bIsDeleted"] is DBNull ? false : ( bool )row["bIsDeleted"];
			oFaculties.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )row["dtAddDate"];
			oFaculties.Remark = row["nvcRemark"] is DBNull ? "" : ( string )row["nvcRemark"];
			oFaculties.SchoolID = row["guSchoolID"] is DBNull ? Guid.Empty : ( Guid )row["guSchoolID"];

			return oFaculties;

		}
	}
}
