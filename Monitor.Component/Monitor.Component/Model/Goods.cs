using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class Goods
    {


        /// <summary>
        /// The guGoodsID
        /// </summary>
        public Guid GoodsID
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcBrand
        /// </summary>
        public string Brand
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcModel
        /// </summary>
        public string Model
        {
            get;
            set;
        }

        /// <summary>
        /// The bInvoice
        /// </summary>
        public bool Invoice
        {
            get;
            set;
        }

        /// <summary>
        /// The vbinInvoiceInfo
        /// </summary>
        public byte[] InvoiceInfo
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
        /// The iStatus
        /// </summary>
        public short Status
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
        /// The dtUseDate
        /// </summary>
        public DateTime UseDate
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcLabelNumber
        /// </summary>
        public string LabelNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The guStudentID
        /// </summary>
        public string StudentNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The mPrice
        /// </summary>
        public double Price
        {
            get;
            set;
        }
        public string GoodsName
        {
            get;
            set;
        }

        public string GoodsIndex
        {
            get;
            set;
        }

        public string StudentsName
        {
            get;
            set;
        }

        public string AllInfo
        {
            get;
            set;
        }

    }
}
