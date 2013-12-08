using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Monitor.Component.DAL;
using Monitor.Component.Model;

namespace Monitor.Component.BLL
{
    public class GoodsManager
    {
        #region 获取学生的物品信息

        /// <summary>
        /// 获取指定的物品信息
        /// </summary>
        /// <param name="guGoodsID">物品标识</param>
        /// <returns></returns>
        public DataTable GetGoods ( Guid guGoodsID )
        {
            return new GoodsDAL ( ).GetGoods (guGoodsID);
        }

        /// <summary>
        /// 获取指定的物品信息
        /// </summary>
        /// <param name="labelNumber"></param>
        /// <returns></returns>
        public Goods GetGoodsByLabelNumber ( string labelNumber )
        {
            DataTable table = new GoodsDAL ( ).GetGoodsByLabelNumber (labelNumber);

            if (table == null || table.Rows.Count == 0)
            {
                return null;
            }

            return ParseModel (table.Rows[0]);
        }
        #endregion

        #region 保存学生的物品
        /// <summary>
        /// 保存学生的物品
        /// </summary>
        /// <param name="oGoods">物品实体</param>
        /// <returns></returns>
        public bool AddGoods ( Goods oGoods )
        {
            return new GoodsDAL ( ).AddGoods (oGoods);
        }

        /// <summary>
        /// 更新物品的状态
        /// </summary>
        /// <param name="goodsID"></param>
        /// <returns></returns>
        public bool UpdateGoodsStatus ( Guid goodsID, int status )
        {
            return new GoodsDAL ( ).UpdateGoodsStatus (goodsID, status);
        }


        public bool DeletedGoods ( Guid goodsID )
        {
            return new GoodsDAL ( ).DeletedGoods (goodsID);
        }

        #endregion

        public List<Goods> GetGoodsByCondition ( string condition )
        {

            if (string.IsNullOrEmpty (condition))
            {
                condition = "1=1";
            }

            DataTable dt = new GoodsDAL ( ).GetGoodsByCondition (condition);

            List<Goods> oList = new List<Goods> ( );

            foreach (DataRow row in dt.Rows)
            {
                oList.Add (ParseModel (row));
            }

            return oList;
        }

        public bool AddGoodsToClient ( Goods oGoods, Students oStudents, Labels oLabels, string strSqlConnection )
        {
            return new GoodsDAL ( ).AddGoodsToClient (oGoods, oStudents, oLabels, strSqlConnection);
        }

        private static Goods ParseModel ( DataRow row )
        {
            Goods oGoods = new Goods ( );

            oGoods.GoodsID = row["guGoodsID"] is DBNull ? Guid.Empty : (Guid)row["guGoodsID"];
            oGoods.Brand = row["nvcBrand"] is DBNull ? "" : (string)row["nvcBrand"];
            oGoods.GoodsName = row["nvcGoodsName"] is DBNull ? "" : (string)row["nvcGoodsName"];
            oGoods.Model = row["nvcModel"] is DBNull ? "" : (string)row["nvcModel"];
            oGoods.Invoice = row["bInvoice"] is DBNull ? false : (bool)row["bInvoice"];
            oGoods.InvoiceInfo = row["vbinInvoiceInfo"] is DBNull ? null : (byte[])row["vbinInvoiceInfo"];
            oGoods.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : (DateTime)row["dtAddDate"];
            oGoods.Status = row["iStatus"] is DBNull ? (short)0 : (short)row["iStatus"];
            oGoods.Remark = row["nvcRemark"] is DBNull ? "" : (string)row["nvcRemark"];
            oGoods.UseDate = row["dtUseDate"] is DBNull ? DateTime.Now : (DateTime)row["dtUseDate"];
            oGoods.LabelNumber = row["nvcLabelNumber"] is DBNull ? "" : (string)row["nvcLabelNumber"];
            oGoods.Price = row["mPrice"] is DBNull ? 0 : Convert.ToDouble (row["mPrice"]);
            oGoods.StudentNumber = row["nvcStudentNumber"] is DBNull ? "" : (string)row["nvcStudentNumber"];

            if (!string.IsNullOrEmpty (oGoods.StudentNumber))
            {
                oGoods.StudentsName = (new StudentManager ( ).GetStudent (oGoods.StudentNumber) ?? new Students ( ) { StudentName = "" }).StudentName;
            }

            return oGoods;

        }
    }
}
