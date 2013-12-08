using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class DormAdmin
	{


		/// <summary>
		/// 标识列
		/// </summary>
		public Guid DormAdmins
		{
			get;
			set;
		}

		/// <summary>
		/// 管理员姓名
		/// </summary>
		public string AdminName
		{
			get;
			set;
		}

		/// <summary>
		/// 管理的楼层
		/// </summary>
		public string ManangerFloor
		{
			get;
			set;
		}

		/// <summary>
		/// 电话
		/// </summary>
		public string Mobile
		{
			get;
			set;
		}

		/// <summary>
		/// 状态
		/// </summary>
		public int Status
		{
			get;
			set;
		}

		/// <summary>
		/// 扩展
		/// </summary>
		public string Remark
		{
			get;
			set;
		}

		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
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

		/// <summary>
		/// 是否删除
		/// </summary>
		public bool IsDeleted
		{
			get;
			set;
		}

		/// <summary>
		/// 卡号
		/// </summary>
		public int? CardNumber
		{
			get;
			set;
		}

	}
}

