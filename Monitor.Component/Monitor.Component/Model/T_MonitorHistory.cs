using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class T_MonitorHistory
    {


        /// <summary>
        /// The HistoryID
        /// </summary>
        public int HistoryID
        {
            get;
            set;
        }

        /// <summary>
        /// The ReceiveTime
        /// </summary>
        public DateTime ReceiveTime
        {
            get;
            set;
        }

        /// <summary>
        /// The OrderNumber
        /// </summary>
        public int OrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The LabelMac
        /// </summary>
        public string LabelMac
        {
            get;
            set;
        }

        /// <summary>
        /// The APMac
        /// </summary>
        public string APMac
        {
            get;
            set;
        }

        /// <summary>
        /// The SignalStrong
        /// </summary>
        public int SignalStrong
        {
            get;
            set;
        }

        /// <summary>
        /// The IsWarning
        /// </summary>
        public bool IsWarning
        {
            get;
            set;
        }

        /// <summary>
        /// The IsDestroy
        /// </summary>
        public bool IsDestroy
        {
            get;
            set;
        }

        /// <summary>
        /// The IsRead
        /// </summary>
        public bool IsRead
        {
            get;
            set;
        }

        /// <summary>
        /// The IsLess
        /// </summary>
        public bool IsLess
        {
            get;
            set;
        }

    }
}
