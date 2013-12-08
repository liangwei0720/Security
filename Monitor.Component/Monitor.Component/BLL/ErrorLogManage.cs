using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Monitor.Component.DAL;
using Monitor.Component.Model;

namespace Monitor.Component.BLL
{
    public class ErrorLogManager
    {
        /// <summary>
        /// 获取一个指定的错误信息
        /// </summary>
        /// <param name="GuidID"></param>
        /// <returns></returns>
        public static ErrorLog GetErrorLog ( Guid GuidID )
        {
            ErrorLog oErrorLog = null;

            DataTable dt = ErrorLogData.GetErrorLog (GuidID);

            if (dt.Rows.Count > 0)
            {
                oErrorLog = new ErrorLog ( );
                oErrorLog = ParseErrorLog (dt.Rows[0]);
            }
            return oErrorLog;

        }
        /// <summary>
        /// 删除一个错误信息
        /// </summary>
        /// <param name="GuidID"></param>
        public static void DeleteErrorLog ( Guid GuidID )
        {
            ErrorLogData.DeleteErrorLog (GuidID);
        }
        /// <summary>
        /// 删除一个错误信息
        /// </summary>
        /// <param name="GuidID"></param>
        /// <param name="ClientIPConnection"></param>
        public static void DeleteErrorLog ( int ID, string ClientIPConnection )
        {
            if (string.IsNullOrEmpty (ClientIPConnection))
            {
                return;
            }
            ErrorLogData.DeleteErrorLog (ID, ClientIPConnection);
        }
        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="oErrorLog"></param>
        public static void SaveErrorLog ( ErrorLog oErrorLog )
        {
            ErrorLogData.SaveErrorLog (oErrorLog);

        }
        /// <summary>
        /// 根据条件获取客户端所有错误信息
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="clientIP"></param>
        /// <returns></returns>
        public static List<ErrorLog> GetErrorLog ( string condition, string clientIP )
        {
            List<ErrorLog> oList = new List<ErrorLog> ( );

            if (string.IsNullOrEmpty (condition))
            {
                condition = " 1=1";
            }

            DataTable dt = ErrorLogData.GetErrorLog (condition, clientIP);

            foreach (DataRow row in dt.Rows)
            {
                oList.Add (ParseErrorLog (row));
            }

            return oList;
        }

        /// <summary>
        /// 根据条件获取客户端所有错误信息
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="clientIP"></param>
        /// <returns></returns>
        public static List<ErrorLog> GetErrorLog ( string condition )
        {
            List<ErrorLog> oList = new List<ErrorLog> ( );

            if (string.IsNullOrEmpty (condition))
            {
                condition = " 1=1";
            }

            DataTable dt = ErrorLogData.GetErrorLog (condition);

            foreach (DataRow row in dt.Rows)
            {
                oList.Add (ParseErrorLog (row));
            }

            return oList;
        }

        private static ErrorLog ParseErrorLog ( DataRow row )
        {
            ErrorLog oErrorLog = new ErrorLog ( );
            oErrorLog.ID = row["ID"] is DBNull ? 0 : (int)row["ID"];
            oErrorLog.IPAddress = row["IPAddress"] is DBNull ? "" : (string)row["IPAddress"];
            oErrorLog.ProjectName = row["ProjectName"] is DBNull ? "" : (string)row["ProjectName"];
            oErrorLog.ErrorMsg = row["ErrorMsg"] is DBNull ? "" : (string)row["ErrorMsg"];
            oErrorLog.ErrorTime = row["ErrorTime"] is DBNull ? DateTime.Now : (DateTime)row["ErrorTime"];
            oErrorLog.FunctionName = row["FunctionName"] is DBNull ? "" : (string)row["FunctionName"];
            oErrorLog.MethodName = row["MethodName"] is DBNull ? "" : (string)row["MethodName"];
            oErrorLog.DormID = row["guDormID"] is DBNull ? Guid.Empty : (Guid)row["guDormID"];
            oErrorLog.GUID = row["guID"] is DBNull ? Guid.Empty : (Guid)row["guID"];

            return oErrorLog;

        }
    }
}
