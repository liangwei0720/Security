using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class Faculties
	{


		/// <summary>
		/// 标识列
		/// </summary>
		public Guid FacultyID
		{
			get;
			set;
		}

		/// <summary>
		/// 院系名称
		/// </summary>
		public string FacultyName
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
		/// 添加时间
		/// </summary>
		public DateTime AddDate
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
		/// 学校ID
		/// </summary>
		public Guid SchoolID
		{
			get;
			set;
		}

	}
}

