using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class ImageInfo
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
        /// The ImageData
        /// </summary>
        public byte[] ImageData
        {
            get;
            set;
        }

        /// <summary>
        /// The ImageName
        /// </summary>
        public string ImageName
        {
            get;
            set;
        }

        /// <summary>
        /// The UpdateTime
        /// </summary>
        public DateTime UpdateTime
        {
            get;
            set;
        }

        /// <summary>
        /// The UpdatePerson
        /// </summary>
        public string UpdatePerson
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
        /// 是否是首次更新数据到客户端
        /// 如果是首次，则需要把原来的数据给清掉
        /// </summary>
        public bool IsFirst
        {
            get;
            set;
        }

    }
}
