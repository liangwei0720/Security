using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class Labels
	{
		/// <summary>
		/// The nvcLabelNumber
		/// </summary>
		public string LabelNumber
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcLabelName
		/// </summary>
		public string LabelName
		{
			get;
			set;
		}

		/// <summary>
		/// The iStatus
		/// </summary>
		public short Status
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcPower
		/// </summary>
		public string Power
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
		/// The guSchoolID
		/// </summary>
		public Guid SchoolID
		{
			get;
			set;
		}

        public Guid DormID
        {
            get;
            set;
        }

	}
}
