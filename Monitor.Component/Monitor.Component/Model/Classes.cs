using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class Classes
	{


		/// <summary>
		/// The guClassID
		/// </summary>
		public Guid ClassID
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcClassName
		/// </summary>
		public string ClassName
		{
			get;
			set;
		}

		/// <summary>
		/// The bIsDeleted
		/// </summary>
		public bool IsDeleted
		{
			get;
			set;
		}

		/// <summary>
		/// The dtAddDate
		/// </summary>
		public DateTime AddDate
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcRemark
		/// </summary>
		public string Remark
		{
			get;
			set;
		}

		/// <summary>
		/// The guFacultyID
		/// </summary>
		public Guid FacultyID
		{
			get;
			set;
		}

	}
}
