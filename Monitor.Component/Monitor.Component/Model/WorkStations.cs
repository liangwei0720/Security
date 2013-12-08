using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
	public class WorkStations
	{
		/// <summary>
		/// The nvcStationID
		/// </summary>
		public string StationID
		{
			get;
			set;
		}

		/// <summary>
		/// The nvcStationPostion
		/// </summary>
		public string StationPostion
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
		/// The nvcStationType
		/// </summary>
		public string StationType
		{
			get;
			set;
		}

		/// <summary>
		/// The guDormID
		/// </summary>
		public Guid DormID
		{
			get;
			set;
		}

	}
}
