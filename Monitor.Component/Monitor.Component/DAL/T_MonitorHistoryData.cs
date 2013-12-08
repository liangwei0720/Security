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
    public class T_MonitorHistoryData : DataExecute
    {
        /// <summary>
        /// 获取指定客户端信息
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="ClientIP"></param>
        /// <returns></returns>
        public static DataTable GetT_MonitorHistoryForLocation ( string condition, string ClientIP )
        {
            string strSqlText = "SELECT  * FROM T_MonitorHistory WHERE " + condition + " Order by [ReceiveTime] DESC";

            SqlDatabase osdDataBase = new SqlDatabase (ClientIP);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (strSqlText);
            DataSet odsData;
            DataTable odtTable;

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            odtTable = odsData.Tables[0];

            return odtTable;
        }


		/// <summary>
		/// 获取指定客户端信息
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="ClientIP"></param>
		/// <returns></returns>
		public static DataTable GetAllT_MonitorHistoryForLocation (string condition , string ClientIP)
		{
			string strSqlText = "SELECT * FROM T_MonitorHistory WHERE " + condition + " Order by ReceiveTime DESC";

			SqlDatabase osdDataBase = new SqlDatabase( ClientIP );
			DbCommand odbCommand = osdDataBase.GetSqlStringCommand( strSqlText );
			DataSet odsData;
			DataTable odtTable;

			odsData = osdDataBase.ExecuteDataSet( odbCommand );
			odtTable = odsData.Tables[0];

			return odtTable;
		}

        /// <summary>
        /// 获取监控历史信息
        /// </summary>
        /// <param name="HistoryID"></param>
        /// <returns></returns>
        public static T_MonitorHistory GetT_MonitorHistory ( int HistoryID )
        {
            string strStoreProcedure = "GetT_MonitorHistory";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);
            DataSet odsData;
            DataTable odtTable;
            T_MonitorHistory oT_MonitorHistory = null;

            osdDataBase.AddInParameter (odbCommand, "@HistoryID", System.Data.DbType.Int64, HistoryID);

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            odtTable = odsData.Tables[0];
            if (odtTable.Rows.Count == 1)
            {
                oT_MonitorHistory = new T_MonitorHistory ( );
                oT_MonitorHistory.HistoryID = odtTable.Rows[0]["HistoryID"] is DBNull ? 0 : (int)odtTable.Rows[0]["HistoryID"];
                oT_MonitorHistory.ReceiveTime = odtTable.Rows[0]["ReceiveTime"] is DBNull ? DateTime.Now : (DateTime)odtTable.Rows[0]["ReceiveTime"];
                oT_MonitorHistory.OrderNumber = odtTable.Rows[0]["OrderNumber"] is DBNull ? 0 : (int)odtTable.Rows[0]["OrderNumber"];
                oT_MonitorHistory.LabelMac = odtTable.Rows[0]["LabelMac"] is DBNull ? "" : (string)odtTable.Rows[0]["LabelMac"];
                oT_MonitorHistory.APMac = odtTable.Rows[0]["APMac"] is DBNull ? "" : (string)odtTable.Rows[0]["APMac"];
                oT_MonitorHistory.SignalStrong = odtTable.Rows[0]["SignalStrong"] is DBNull ? 0 : (int)odtTable.Rows[0]["SignalStrong"];
                oT_MonitorHistory.IsWarning = odtTable.Rows[0]["IsWarning"] is DBNull ? false : (bool)odtTable.Rows[0]["IsWarning"];
                oT_MonitorHistory.IsDestroy = odtTable.Rows[0]["IsDestroy"] is DBNull ? false : (bool)odtTable.Rows[0]["IsDestroy"];
                oT_MonitorHistory.IsRead = odtTable.Rows[0]["IsRead"] is DBNull ? false : (bool)odtTable.Rows[0]["IsRead"];
                oT_MonitorHistory.IsLess = odtTable.Rows[0]["IsLess"] is DBNull ? false : (bool)odtTable.Rows[0]["IsLess"];
            }
            return oT_MonitorHistory;
        }

        /// <summary>
        /// 删除指定监控记录
        /// </summary>
        /// <param name="HistoryID"></param>
        public static void DeleteT_MonitorHistory ( int HistoryID )
        {
            string strStoreProcedure = "DeleteT_MonitorHistory";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@HistoryID", System.Data.DbType.Int64, HistoryID);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }
        /// <summary>
        /// 保存监控记录
        /// </summary>
        /// <param name="oT_MonitorHistory"></param>
        public static void SaveT_MonitorHistory ( T_MonitorHistory oT_MonitorHistory )
        {
            string strStoreProcedure = "SaveT_MonitorHistory";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@ReceiveTime", System.Data.DbType.DateTime, oT_MonitorHistory.ReceiveTime);
            osdDataBase.AddInParameter (odbCommand, "@OrderNumber", System.Data.DbType.Int32, oT_MonitorHistory.OrderNumber);
            osdDataBase.AddInParameter (odbCommand, "@LabelMac", System.Data.DbType.String, oT_MonitorHistory.LabelMac);
            osdDataBase.AddInParameter (odbCommand, "@APMac", System.Data.DbType.String, oT_MonitorHistory.APMac);
            osdDataBase.AddInParameter (odbCommand, "@SignalStrong", System.Data.DbType.Int32, oT_MonitorHistory.SignalStrong);
            osdDataBase.AddInParameter (odbCommand, "@IsWarning", System.Data.DbType.Boolean, oT_MonitorHistory.IsWarning);
            osdDataBase.AddInParameter (odbCommand, "@IsDestroy", System.Data.DbType.Boolean, oT_MonitorHistory.IsDestroy);
            osdDataBase.AddInParameter (odbCommand, "@IsRead", System.Data.DbType.Boolean, oT_MonitorHistory.IsRead);
            osdDataBase.AddInParameter (odbCommand, "@IsLess", System.Data.DbType.Boolean, oT_MonitorHistory.IsLess);
            osdDataBase.AddParameter (odbCommand, "@HistoryID", System.Data.DbType.Int64, ParameterDirection.InputOutput, null, DataRowVersion.Default, oT_MonitorHistory.HistoryID);

            osdDataBase.ExecuteNonQuery (odbCommand);
            oT_MonitorHistory.HistoryID = (int)osdDataBase.GetParameterValue (odbCommand, "@HistoryID");
        }

    }
}
