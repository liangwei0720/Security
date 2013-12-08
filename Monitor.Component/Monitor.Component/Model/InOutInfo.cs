using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class InOutInfo
    {/// <summary>
        /// The guInOutID
        /// </summary>
        public Guid GUInOutID
        {
            get;
            set;
        }

        /// <summary>
        /// The InOutID
        /// </summary>
        public long InOutID
        {
            get;
            set;
        }

        /// <summary>
        /// The InOutTime
        /// </summary>
        public DateTime InOutTime
        {
            get;
            set;
        }

        /// <summary>
        /// The CurrentStatus
        /// </summary>
        public int CurrentStatus
        {
            get;
            set;
        }

        /// <summary>
        /// The LabelCode
        /// </summary>
        public string LabelCode
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

        /// <summary>
        /// The dtAddDate
        /// </summary>
        public DateTime AddDate
        {
            get;
            set;
        }

        public string DormName
        {
            get;
            set;
        }

    }
}

