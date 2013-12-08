using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
	class ClassManager
	{
		/// <summary>
		/// 得到一个班级信息
		/// </summary>
		/// <param name="GuidClassID"></param>
		/// <returns></returns>
		public static Classes GetClasses(Guid GuidClassID)
		{
			DataTable dt = ClassesData.GetClasses(GuidClassID);
			if ( dt.Rows.Count == 0 )
			{
				return null;
			}

			return ParseClass(dt.Rows[0]);
		}

		/// <summary>
		/// 删除班级信息
		/// </summary>
		/// <param name="GuidClassID"></param>
		/// <returns></returns>
		public static int DeleteClasses(Guid GuidClassID)
		{
			return ClassesData.DeleteClasses(GuidClassID);
		}

		/// <summary>
		/// 保存班级信息
		/// </summary>
		/// <param name="oClasses"></param>
		/// <returns></returns>
		public static int SaveClasses(Classes oClasses)
		{
			return ClassesData.SaveClasses(oClasses);
		}

		/// <summary>
		/// 转换实体
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		private static Classes ParseClass(DataRow row)
		{
			Classes oClasses = new Classes( );

			oClasses.ClassID = row["guClassID"] is DBNull ? Guid.Empty : ( Guid )row["guClassID"];
			oClasses.ClassName = row["nvcClassName"] is DBNull ? "" : ( string )row["nvcClassName"];
			oClasses.IsDeleted = row["bIsDeleted"] is DBNull ? false : ( bool )row["bIsDeleted"];
			oClasses.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )row["dtAddDate"];
			oClasses.Remark = row["nvcRemark"] is DBNull ? "" : ( string )row["nvcRemark"];
			oClasses.FacultyID = row["guFacultyID"] is DBNull ? Guid.Empty : ( Guid )row["guFacultyID"];

			return oClasses;

		}
	}
}
