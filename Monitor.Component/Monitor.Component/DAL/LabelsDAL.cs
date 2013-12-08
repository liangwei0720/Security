using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace Monitor.Component.DAL
{
    public class LabelsData : DataExecute
    {
        /// <summary>
        /// 获取指定的标签信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strLabelNumber"></param>
        /// <returns></returns>
        public static DataTable GetLabels ( string strLabelNumber )
        {
            string strStoreProcedure = "GetLabels";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@nvcLabelNumber", System.Data.DbType.String, strLabelNumber);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];
        }

        /// <summary>
        /// 删除指定的标签信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strLabelNumber"></param>
        public static void DeleteLabels ( string strLabelNumber )
        {
            string strStoreProcedure = "DeleteLabels";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@nvcLabelNumber", System.Data.DbType.String, strLabelNumber);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }

        /// <summary>
        /// 保存标签作息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="oLabels"></param>
        public static int SaveLabels ( Labels oLabels )
        {
            string strStoreProcedure = "SaveLabels";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@nvcLabelNumber", System.Data.DbType.String, oLabels.LabelNumber);
            osdDataBase.AddInParameter (odbCommand, "@nvcLabelName", System.Data.DbType.String, oLabels.LabelName);
            osdDataBase.AddInParameter (odbCommand, "@iStatus", System.Data.DbType.Int16, oLabels.Status);
            osdDataBase.AddInParameter (odbCommand, "@nvcPower", System.Data.DbType.String, oLabels.Power);
            osdDataBase.AddInParameter (odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oLabels.AddDate);
            osdDataBase.AddInParameter (odbCommand, "@nvcRemark", System.Data.DbType.String, oLabels.Remark);
            osdDataBase.AddInParameter (odbCommand, "@guSchoolID", System.Data.DbType.Guid, oLabels.SchoolID);

            return osdDataBase.ExecuteNonQuery (odbCommand);

        }

        /// <summary>
        /// 获取所有的标签信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strLabelNumber"></param>
        /// <returns></returns>
        public static DataTable GetAllLabels ( )
        {
            string strStoreProcedure = "GetAllLabels";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];
        }

        /// <summary>
        /// 获取所有的标签信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strLabelNumber"></param>
        /// <returns></returns>
        public static DataTable GetLabelsByCondition ( string condition )
        {
            string strStoreProcedure = @"SELECT [nvcLabelNumber],[nvcLabelName],[iStatus],[nvcPower],[dtAddDate],[nvcRemark],[guSchoolID],[bIsDeleted],[guDormID]
	                                    FROM Labels 
                                        WHERE " + condition;
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (strStoreProcedure);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];
        }

        /// <summary>
        /// 更新标签的状态
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static bool UpdateLabelStatus ( string condition, Guid guDormID, int status )
        {
            string strStoreProcedure = @"UPDATE Labels SET [iStatus]=" + status.ToString ( ) + ",guDormID='" + guDormID.ToString ( ) + "' WHERE " + condition;
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (strStoreProcedure);

            return osdDataBase.ExecuteNonQuery (odbCommand) > 0;
        }

        /// <summary>
        /// 获取学生的所有物品信息，用于销户时用
        /// </summary>
        /// <param name="condtion"></param>
        /// <returns></returns>
        public static DataTable GetStudentLabelsWithRepealLabel ( string condtion )
        {
            string sqlText = "SELECT * FROM vw_studentGoods WHERE " + condtion;
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (sqlText);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];
        }

        /// <summary>
        /// 销户标签
        /// </summary>
        /// <param name="labelNumber"></param>
        /// <param name="studentNumber"></param>
        /// <returns></returns>
        public static bool RepealLabels ( string labelNumber, string studentNumber, Guid guGoodsID )
        {
            string sqlText = @"UPDATE Labels SET iStatus=0 WHERE nvcLabelNumber=@labelNumber;
                               DELETE Goods WHERE guGoodsID=@guGoodsID;
            IF NOT EXISTS( SELECT 1 FROM Goods WHERE nvcStudentNumber=@studentNumber)
            BEGIN
                UPDATE Cards SET iCardStatus=0 WHERE iCardNumber=(SELECT iCardNumber FROM Students WHERE nvcStudentNumber=@studentNumber);
                DELETE Students WHERE nvcStudentNumber=@studentNumber;
            END
            ";

            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (sqlText);

            osdDataBase.AddInParameter (odbCommand, "@labelNumber", System.Data.DbType.String, labelNumber);
            osdDataBase.AddInParameter (odbCommand, "@studentNumber", System.Data.DbType.String, studentNumber);
            osdDataBase.AddInParameter (odbCommand, "@guGoodsID", System.Data.DbType.Guid, guGoodsID);

            return osdDataBase.ExecuteNonQuery (odbCommand) > 0;
        }
    }
}