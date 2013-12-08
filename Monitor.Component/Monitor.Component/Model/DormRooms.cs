using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class DormRooms
	{
		/// <summary>
		/// 标识列
		/// </summary>
		public Guid RoomID
		{
			get;
			set;
		}

		/// <summary>
		/// 编号
		/// </summary>
		public string RoomNumber
		{
			get;
			set;
		}

		/// <summary>
		/// 是否删除
		/// </summary>
		public bool IsDeleted
		{
			get;
			set;
		}

		/// <summary>
		///添加时间
		/// </summary>
		public DateTime AddDate
		{
			get;
			set;
		}

		/// <summary>
		/// 扩展信息
		/// </summary>
		public string Remark
		{
			get;
			set;
		}

		/// <summary>
		/// 所属公寓
		/// </summary>
		public Guid DormID
		{
			get;
			set;
		}

	}
}

