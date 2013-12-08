using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
	public class DormAdminManager
	{
		/// <summary>
		/// 获取一个公寓管理员信息
		/// </summary>	
		/// <param name="GuidDormAdmins"></param>
		/// <returns></returns>
		public static DormAdmin GetDormAdmins (Guid GuidDormAdmins)
		{
			DataTable dt = DormAdminsData.GetDormAdmins( GuidDormAdmins );

			if ( dt.Rows.Count == 0 )
			{
				return null;
			}
			return ParseDormAdmin( dt.Rows[0] );
		}

		/// <summary>
		/// 删除一个公寓管理员
		/// </summary>
		/// <param name="ClientSqlConnection"></param>
		/// <param name="GuidDormAdmins"></param>
		public static bool DeleteDormAdmins (Guid GuidDormAdmins , string ClientSqlConnection)
		{
			if ( DormAdminsData.DeleteDormAdmins( GuidDormAdmins , ClientSqlConnection ) > 0 )
			{
				return DormAdminsData.DeleteDormAdmins( GuidDormAdmins ) > 0;
			}

			return false;
		}

		/// <summary>
		/// 保存管理员信息
		/// </summary>
		/// <param name="oDormAdmins"></param>
		/// <param name="ClientSqlConnection"></param>
		/// <returns></returns>
		public static bool SaveDormAdmins (DormAdmin oDormAdmins , string ClientSqlConnection)
		{
			if ( DormAdminsData.SaveDormAdmins( oDormAdmins ) > 0 )
			{
				return DormAdminsData.SaveDormAdmins( oDormAdmins , ClientSqlConnection ) > 0;
			}
			return false;

		}

		/// <summary>
		/// 获取所有的管理员信息
		/// </summary>
		/// <returns></returns>
		public static List<DormAdmin> GetAllDormAdmins (string condition)
		{
			DataTable table= DormAdminsData.GetAllDormAdmins( condition );

			List<DormAdmin> oList = new List<DormAdmin>( );

			if ( table == null || table.Rows.Count == 0 )
			{
				return oList;
			}

			foreach ( DataRow row in table.Rows )
			{
				oList.Add( ParseDormAdmin( row ) );
			}

			return oList;
		}

		/// <summary>
		/// 实体转换
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		private static DormAdmin ParseDormAdmin (DataRow row)
		{
			DormAdmin oDormAdmins = new DormAdmin( );

			oDormAdmins.DormAdmins = row["guDormAdmins"] is DBNull ? Guid.Empty : ( Guid )row["guDormAdmins"];
			oDormAdmins.AdminName = row["nvcAdminName"] is DBNull ? "" : ( string )row["nvcAdminName"];
			oDormAdmins.ManangerFloor = row["nvcManangerFloor"] is DBNull ? "" : ( string )row["nvcManangerFloor"];
			oDormAdmins.Mobile = row["vcMobile"] is DBNull ? null : ( string )row["vcMobile"];
			oDormAdmins.Status = row["iStatus"] is DBNull ? 0 : ( int )row["iStatus"];
			oDormAdmins.Remark = row["nvcRemark"] is DBNull ? "" : ( string )row["nvcRemark"];
			oDormAdmins.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )row["dtAddDate"];
			oDormAdmins.DormID = row["guDormID"] is DBNull ? Guid.Empty : ( Guid )row["guDormID"];
			oDormAdmins.IsDeleted = row["bIsDeleted"] is DBNull ? false : ( bool )row["bIsDeleted"];
			oDormAdmins.CardNumber = row["iCardNumber"] is DBNull ? 0 : ( int )row["iCardNumber"];

			return oDormAdmins;
		}
	}
}
