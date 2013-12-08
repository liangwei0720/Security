using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;
using Monitor.Component.Model;

namespace Monitor.Component.DAL
{
    public class ErrorLogData : DataExecute
    {
        /// <summary>
        /// 获取一个指定的错误信息
        /// </summary>
        /// <param name="GuidID"></param>
        /// <returns></returns>
        public static DataTable GetErrorLog ( Guid GuidID )
        {
            string strStoreProcedure = "GetErrorLog";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);
            DataSet odsData;

            osdDataBase.AddInParameter (odbCommand, "@guID", System.Data.DbType.Guid, GuidID);

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            return odsData.Tables[0];

        }
        /// <summary>
        /// 删除一个错误信息
        /// </summary>
        /// <param name="GuidID"></param>
        public static void DeleteErrorLog ( Guid GuidID )
        {
            string strStoreProcedure = "DeleteErrorLog";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@guID", System.Data.DbType.Guid, GuidID);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }

        /// <summary>
        /// 删除一个错误信息
        /// </summary>
        /// <param name="GuidID"></param>
        /// <param name="ClientIPConnection"></param>
        public static void DeleteErrorLog ( int ID, string ClientIPConnection )
        {
            string strStoreProcedure = "DeleteErrorLogByServer";
            SqlDatabase osdDataBase = new SqlDatabase (ClientIPConnection);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@ID", System.Data.DbType.Int32, ID);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }
        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="oErrorLog"></param>
        public static void SaveErrorLog ( ErrorLog oErrorLog )
        {
            string strStoreProcedure = "SaveErrorLog";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@ID", System.Data.DbType.Int64, oErrorLog.ID);
            osdDataBase.AddInParameter (odbCommand, "@IPAddress", System.Data.DbType.String, oErrorLog.IPAddress);
            osdDataBase.AddInParameter (odbCommand, "@ProjectName", System.Data.DbType.String, oErrorLog.ProjectName);
            osdDataBase.AddInParameter (odbCommand, "@ErrorMsg", System.Data.DbType.String, oErrorLog.ErrorMsg);
            osdDataBase.AddInParameter (odbCommand, "@ErrorTime", System.Data.DbType.DateTime, oErrorLog.ErrorTime);
            osdDataBase.AddInParameter (odbCommand, "@FunctionName", System.Data.DbType.String, oErrorLog.FunctionName);
            osdDataBase.AddInParameter (odbCommand, "@MethodName", System.Data.DbType.String, oErrorLog.MethodName);
            osdDataBase.AddInParameter (odbCommand, "@guDormID", System.Data.DbType.Guid, oErrorLog.DormID);
            osdDataBase.AddInParameter (odbCommand, "@guID", System.Data.DbType.Guid, oErrorLog.GUID);

            osdDataBase.ExecuteNonQuery (odbCommand);

        }

        /// <summary>
        /// 根据条件获取客户端所有错误信息
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="clientIP"></param>
        /// <returns></returns>
        public static DataTable GetErrorLog ( string condition, string clientIP )
        {
            SqlDatabase osdDataBase = new SqlDatabase (clientIP);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand ("SELECT *,null as guDormID,null as guid FROM T_ErrorLog WHERE " + condition);
            DataSet odsData;

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            return odsData.Tables[0];
        }

        /// <summary>
        /// 根据条件获取客户端所有错误信息
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="clientIP"></param>
        /// <returns></returns>
        public static DataTable GetErrorLog ( string condition )
        {
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand ("SELECT * FROM ErrorLog WHERE " + condition);
            DataSet odsData;

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            return odsData.Tables[0];
        }

    }
}
