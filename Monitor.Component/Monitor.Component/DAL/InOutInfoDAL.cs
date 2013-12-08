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
    public class InOutInfoData : DataExecute
    {
        public static InOutInfo GetInOutInfo ( Guid guInOutID )
        {
            string strStoreProcedure = "GetInOutInfo";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);
            DataSet odsData;
            DataTable odtTable;
            InOutInfo oInOutInfo = null;

            osdDataBase.AddInParameter (odbCommand, "@guInOutID", System.Data.DbType.Guid, guInOutID);

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            odtTable = odsData.Tables[0];
            if (odtTable.Rows.Count == 1)
            {
                oInOutInfo = new InOutInfo ( );
                oInOutInfo.GUInOutID = odtTable.Rows[0]["guInOutID"] is DBNull ? Guid.Empty : (Guid)odtTable.Rows[0]["guInOutID"];
                oInOutInfo.InOutID = odtTable.Rows[0]["InOutID"] is DBNull ? 0 : (int)odtTable.Rows[0]["InOutID"];
                oInOutInfo.InOutTime = odtTable.Rows[0]["InOutTime"] is DBNull ? DateTime.Now : (DateTime)odtTable.Rows[0]["InOutTime"];
                oInOutInfo.CurrentStatus = odtTable.Rows[0]["CurrentStatus"] is DBNull ? 0 : (int)odtTable.Rows[0]["CurrentStatus"];
                oInOutInfo.LabelCode = odtTable.Rows[0]["LabelCode"] is DBNull ? "" : (string)odtTable.Rows[0]["LabelCode"];
                oInOutInfo.DormID = odtTable.Rows[0]["guDormID"] is DBNull ? Guid.Empty : (Guid)odtTable.Rows[0]["guDormID"];
                oInOutInfo.AddDate = odtTable.Rows[0]["dtAddDate"] is DBNull ? DateTime.Now : (DateTime)odtTable.Rows[0]["dtAddDate"];
            }
            return oInOutInfo;

        }
        public static void DeleteInOutInfo ( Guid guInOutID )
        {
            string strStoreProcedure = "DeleteInOutInfo";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@guInOutID", System.Data.DbType.Guid, guInOutID);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }

        public static void DeleteInOutInfo ( long InOutID, string ClientIPString )
        {
            string strStoreProcedure = "DeleteInOutInfoByServer";
            SqlDatabase osdDataBase = new SqlDatabase (ClientIPString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@InOutID", System.Data.DbType.Int32, InOutID);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }

        public static void SaveInOutInfo ( InOutInfo oInOutInfo )
        {
            string strStoreProcedure = "SaveInOutInfo";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@guInOutID", System.Data.DbType.Guid, oInOutInfo.GUInOutID);
            osdDataBase.AddInParameter (odbCommand, "@InOutID", System.Data.DbType.Int32, oInOutInfo.InOutID);
            osdDataBase.AddInParameter (odbCommand, "@InOutTime", System.Data.DbType.DateTime, oInOutInfo.InOutTime);
            osdDataBase.AddInParameter (odbCommand, "@CurrentStatus", System.Data.DbType.Int32, oInOutInfo.CurrentStatus);
            osdDataBase.AddInParameter (odbCommand, "@LabelCode", System.Data.DbType.String, oInOutInfo.LabelCode);
            osdDataBase.AddInParameter (odbCommand, "@guDormID", System.Data.DbType.Guid, oInOutInfo.DormID);
            osdDataBase.AddInParameter (odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oInOutInfo.AddDate);


            osdDataBase.ExecuteNonQuery (odbCommand);

        }
        /// <summary>
        /// 获取出入记录
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static DataTable GetListByCondition ( string condition )
        {
            string strSqlText = "SELECT * FROM InOutInfo WHERE " + condition;
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (strSqlText);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];

        }
        /// <summary>
        /// 从指定的客户端获取出入记录
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="clientSqlConnectionString"></param>
        /// <returns></returns>
        public static DataTable GetListByCondition ( string condition, string clientSqlConnectionString )
        {
			string strSqlText = "SELECT *,null as guInOutID,null as guDormID,getdate() as dtAddDate FROM T_InOutInfo WHERE " + condition;
            SqlDatabase osdDataBase = new SqlDatabase (clientSqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (strSqlText);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];

        }

        public static DataTable GetInOurByCondition ( string condition )
        {
            string strSqlText = "SELECT * FROM vw_InOut WHERE " + condition;
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetSqlStringCommand (strSqlText);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];

        }

    }
}
