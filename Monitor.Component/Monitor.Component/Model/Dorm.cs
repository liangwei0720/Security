using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class Dorm
    {


        /// <summary>
        /// The guDormID
        /// </summary>
        public Guid DormID
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcDormNumber
        /// </summary>
        public string DormNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The iFlools
        /// </summary>
        public short Flools
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
        /// The guSchoolID
        /// </summary>
        public Guid SchoolID
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
