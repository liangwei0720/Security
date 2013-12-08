using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class Schools
	{


		/// <summary>
		/// The guSchoolID
		/// </summary>
		public Guid SchoolID
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcSchoolName
		/// </summary>
		public string SchoolName
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcSchoolCode
		/// </summary>
		public string SchoolCode
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcSchoolCampus
		/// </summary>
		public string SchoolCampus
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcSchoolSummary
		/// </summary>
		public string SchoolSummary
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
		/// The dtAddDate
		/// </summary>
		public DateTime AddDate
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

	}
}
