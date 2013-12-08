using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class Server
    {


        /// <summary>
        /// The iServerID
        /// </summary>
        public int ServerID
        {
            get;
            set;
        }

        /// <summary>
        /// The vcServerName
        /// </summary>
        public string ServerName
        {
            get;
            set;
        }

        /// <summary>
        /// The vcIP
        /// </summary>
        public string IP
        {
            get;
            set;
        }

        /// <summary>
        /// The dtLastUpdate
        /// </summary>
        public DateTime LastUpdate
        {
            get;
            set;
        }

        /// <summary>
        /// The bIsSuccess
        /// </summary>
        public bool IsSuccess
        {
            get;
            set;
        }

        public Guid GuDormID
        {
            get;
            set;
        }

        public string Connection
        {
            get;
            set;
        }

    }

}
