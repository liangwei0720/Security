using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
	public class DormRoomManager
	{
		/// <summary>
		/// 获取一个宿舍信息
		/// </summary>
		/// <param name="GuidRoomID"></param>
		/// <returns></returns>
		public static DormRooms GetDormRooms (Guid GuidRoomID)
		{
			DataTable dt = DormRoomsData.GetDormRooms( GuidRoomID );

			if ( dt.Rows.Count == 0 )
			{
				return null;
			}

			return ParseDormRoom( dt.Rows[0] );
		}

		/// <summary>
		/// 删除一个宿舍信息
		/// </summary>
		/// <param name="GuidRoomID"></param>
		/// <returns></returns>
		public static bool DeleteDormRooms (Guid GuidRoomID)
		{
			return DormRoomsData.DeleteDormRooms( GuidRoomID ) > 0;
		}

		/// <summary>
		/// 保存宿舍信息
		/// </summary>
		/// <param name="oDormRooms"></param>
		public static bool SaveDormRooms (DormRooms oDormRooms)
		{
			return DormRoomsData.SaveDormRooms( oDormRooms ) > 0;
		}

		/// <summary>
		/// 保存宿舍信息
		/// </summary>
		/// <param name="oDormRooms"></param>
		public static bool SaveDormRooms (DormRooms oDormRooms , string sqlCoonection)
		{
			return DormRoomsData.SaveDormRooms( oDormRooms , sqlCoonection ) > 0;
		}

		/// <summary>
		/// 根据条件获取宿舍信息
		/// </summary>
		/// <param name="condition"></param>
		/// <returns></returns>
		public static DataTable GetDormRoomsByCondtion (string condition)
		{
			if ( string.IsNullOrEmpty( condition ) )
			{
				condition = "1=1";
			}

			return DormRoomsData.GetDormRoomsByCondtion( condition );
		}

		/// <summary>
		/// 获取宿舍信息
		/// </summary>
		/// <returns></returns>
		public static List<DormRooms> GetAllDormRooms ( )
		{
			DataTable dt = DormRoomsData.GetDormRoomsByCondtion( "1=1" );
			List<DormRooms> oList = new List<DormRooms>( );
			foreach ( DataRow row in dt.Rows )
			{
				oList.Add( ParseDormRoom( row ) );
			}
			return oList;
		}

		/// <summary>
		/// 转换实体
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		private static DormRooms ParseDormRoom (DataRow row)
		{
			DormRooms oDormRooms = new DormRooms( );

			oDormRooms.RoomID = row["guRoomID"] is DBNull ? Guid.Empty : ( Guid )row["guRoomID"];
			oDormRooms.RoomNumber = row["nvcRoomNumber"] is DBNull ? "" : ( string )row["nvcRoomNumber"];
			oDormRooms.IsDeleted = row["bIsDeleted"] is DBNull ? false : ( bool )row["bIsDeleted"];
			oDormRooms.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )row["dtAddDate"];
			oDormRooms.Remark = row["nvcRemark"] is DBNull ? "" : ( string )row["nvcRemark"];
			oDormRooms.DormID = row["guDormID"] is DBNull ? Guid.Empty : ( Guid )row["guDormID"];

			return oDormRooms;

		}
	}
}
