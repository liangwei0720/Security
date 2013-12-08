using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
	public class DormManager
	{
		/// <summary>
		/// 得到一个公寓信息
		/// </summary>
		/// <param name="GuidDormID"></param>
		/// <returns></returns>
		public static Dorm GetDorm (Guid GuidDormID)
		{
			DataTable dt = DormData.GetDorm( GuidDormID );

			if ( dt.Rows.Count == 0 )
			{
				return null;
			}

			return ParseModel( dt.Rows[0] );

		}
		/// <summary>
		/// 删除一个公寓信息
		/// </summary>
		/// <param name="GuidDormID"></param>
		public static bool DeleteDorm (Guid GuidDormID)
		{
			return DormData.DeleteDorm( GuidDormID ) > 0;
		}

		/// <summary>
		/// 获取所有的公寓类信息
		/// </summary>
		/// <returns></returns>
		public static DataTable GetAllDorm ( )
		{
			return DormData.GetAllDorm( );
		}

		/// <summary>
		/// 保存公寓信息
		/// </summary>
		/// <param name="oDorm"></param>
		public static bool SaveDorm (Dorm oDorm)
		{
			return DormData.SaveDorm( oDorm ) > 0;

		}

		/// <summary>
		/// 保存公寓信息
		/// </summary>
		/// <param name="oDorm"></param>
		public static bool SaveDorm (Dorm oDorm , string sqlConnection)
		{
			return DormData.SaveDorm( oDorm , sqlConnection ) > 0;

		}

		/// <summary>
		/// 获取所有的公寓类信息
		/// </summary>
		/// <returns></returns>
		public static List<Dorm> GetAllDormWithList ( )
		{
			List<Dorm> oList = new List<Dorm>( );

			DataRowCollection dtRows = DormData.GetAllDorm( ).Rows;

			foreach ( DataRow row in dtRows )
			{
				oList.Add( ParseModel( row ) );
			}

			return oList;
		}

		/// <summary>
		/// 转换实体
		/// </summary>
		/// <param name="row"></param>
		private static Dorm ParseModel (DataRow row)
		{
			Dorm oDorm = new Dorm( );

			oDorm.DormID = row["guDormID"] is DBNull ? Guid.Empty : ( Guid )row["guDormID"];
			oDorm.DormNumber = row["nvcDormNumber"] is DBNull ? "" : ( string )row["nvcDormNumber"];
			oDorm.Flools = row["iFlools"] is DBNull ? ( short )0 : ( short )row["iFlools"];
			oDorm.Remark = row["nvcRemark"] is DBNull ? "" : ( string )row["nvcRemark"];
			oDorm.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )row["dtAddDate"];
			oDorm.SchoolID = row["guSchoolID"] is DBNull ? Guid.Empty : ( Guid )row["guSchoolID"];
			oDorm.IsDeleted = row["bIsDeleted"] is DBNull ? false : ( bool )row["bIsDeleted"];

			return oDorm;
		}
	}
}
