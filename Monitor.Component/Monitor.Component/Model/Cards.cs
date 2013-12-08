using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class Cards
	{
		/// <summary>
		/// The iCardNumber
		/// </summary>
		public int CardNumber
		{
			get ;
			set ;
		}

		/// <summary>
		/// The nvcSchoolCode
		/// </summary>
		public string SchoolCode
		{
			get ;
			set ;
		}

		/// <summary>
		/// The iCardStatus
		/// </summary>
		public short CardStatus
		{
			get ;
			set ;
		}

		/// <summary>
		/// The nvcRemark
		/// </summary>
		public string Remark
		{
			get ;
			set ;
		}

		/// <summary>
		/// The dtAddDate
		/// </summary>
		public DateTime AddDate
		{
			get ;
			set ;
		}

		/// <summary>
		/// The bIsDeleted
		/// </summary>
		public bool IsDeleted
		{
			get ;
			set ;
		}

	}
}