using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class ErrorLog
    {
        /// <summary>
        /// The ID
        /// </summary>
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// The IPAddress
        /// </summary>
        public string IPAddress
        {
            get;
            set;
        }

        /// <summary>
        /// The ProjectName
        /// </summary>
        public string ProjectName
        {
            get;
            set;
        }

        /// <summary>
        /// The ErrorMsg
        /// </summary>
        public string ErrorMsg
        {
            get;
            set;
        }

        /// <summary>
        /// The ErrorTime
        /// </summary>
        public DateTime ErrorTime
        {
            get;
            set;
        }

        /// <summary>
        /// The FunctionName
        /// </summary>
        public string FunctionName
        {
            get;
            set;
        }

        /// <summary>
        /// The MethodName
        /// </summary>
        public string MethodName
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
        /// The guID
        /// </summary>
        public Guid GUID
        {
            get;
            set;
        }

    }
}
