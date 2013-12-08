using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
    public class LabelManager
    {
        #region 添加标签
        /// <summary>
        /// 添加标签信息
        /// </summary>
        /// <param name="oLabel">实体对象</param>
        /// <returns></returns>
        public static bool SaveLabels ( Labels oLabel )
        {
            return LabelsData.SaveLabels (oLabel) > 0;
        }
        #endregion


        #region 获取一个指定的标签信息
        /// <summary>
        /// 获取一个指定的标签信息
        /// </summary>      
        /// <param name="strLabelNumber"></param>
        /// <returns></returns>
        public static Labels GetLabels ( string strLabelNumber )
        {
            DataTable dt = LabelsData.GetLabels (strLabelNumber);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            return ParseLabel (dt.Rows[0]);
        }
        #endregion


        #region 获取一个指定的标签信息
        /// <summary>
        /// 获取一个指定的标签信息
        /// </summary>      
        /// <param name="strLabelNumber"></param>
        /// <returns></returns>
        public static List<Labels> GetAllLabels ( )
        {
            DataTable dt = LabelsData.GetAllLabels ( );
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Labels> olist = new List<Labels> ( );

            Labels oLabels;
            foreach (DataRow row in dt.Rows)
            {
                oLabels = ParseLabel (row);
                olist.Add (oLabels);
            }

            return olist;
        }

        /// <summary>
        /// 获取一个指定的标签信息
        /// </summary>      
        /// <param name="strLabelNumber"></param>
        /// <returns></returns>
        public static List<Labels> GetLabelsByCondition ( string condition )
        {
            if (string.IsNullOrEmpty (condition))
            {
                condition = " bIsDeleted=0 ";
            }
            else
            {
                condition = " bIsDeleted=0 AND " + condition;
            }

            DataTable dt = LabelsData.GetLabelsByCondition (condition);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Labels> olist = new List<Labels> ( );

            Labels oLabels;
            foreach (DataRow row in dt.Rows)
            {
                oLabels = ParseLabel (row);
                olist.Add (oLabels);
            }

            return olist;
        }
        #endregion

        #region 删除标签
        /// <summary>
        /// 删除指定的标签信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strLabelNumber"></param>
        public static void DeleteLabels ( string strLabelNumber )
        {
            LabelsData.DeleteLabels (strLabelNumber);
        }
        #endregion

        #region 转换对象
        /// <summary>
        /// 转换对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static Labels ParseLabel ( DataRow row )
        {
            Model.Labels oLabels = new Labels ( );

            oLabels.LabelNumber = row["nvcLabelNumber"] is DBNull ? "" : (string)row["nvcLabelNumber"];
            oLabels.LabelName = row["nvcLabelName"] is DBNull ? "" : (string)row["nvcLabelName"];
            oLabels.Status = row["iStatus"] is DBNull ? (short)0 : (short)row["iStatus"];
            oLabels.Power = row["nvcPower"] is DBNull ? "" : (string)row["nvcPower"];
            oLabels.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : (DateTime)row["dtAddDate"];
            oLabels.Remark = row["nvcRemark"] is DBNull ? "" : (string)row["nvcRemark"];
            oLabels.SchoolID = row["guSchoolID"] is DBNull ? Guid.Empty : (Guid)row["guSchoolID"];
            oLabels.DormID = row["guDormID"] is DBNull ? Guid.Empty : (Guid)row["guDormID"];

            return oLabels;
        }
        #endregion

        /// <summary>
        /// 更新标签的状态
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static bool UpdateLabelStatus ( string condition, Guid guDormId, int status )
        {
            return LabelsData.UpdateLabelStatus (condition, guDormId, status);
        }

        /// <summary>
        /// 获取学生的所有物品信息，用于销户时用
        /// </summary>
        /// <param name="condtion"></param>
        /// <returns></returns>
        public static DataTable GetStudentLabelsWithRepealLabel ( string condtion )
        {
            if (string.IsNullOrEmpty (condtion))
            {
                condtion = "1=1";
            }
            return LabelsData.GetStudentLabelsWithRepealLabel (condtion);
        }

        /// <summary>
        /// 销户标签
        /// </summary>
        /// <param name="labelNumber"></param>
        /// <param name="studentNumber"></param>
        /// <returns></returns>
        public static bool RepealLabels ( string labelNumber, string studentNumber, Guid guGoodsID )
        {
            return LabelsData.RepealLabels (labelNumber, studentNumber, guGoodsID);
        }
    }
}
