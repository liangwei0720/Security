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
    public class WorkStationsData : DataExecute
    {
        /// <summary>
        /// 获取指定的工作站信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strStationID"></param>
        /// <returns></returns>
        public static DataTable GetWorkStations ( string strStationID )
        {
            string strStoreProcedure = "GetWorkStations";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@nvcStationID", System.Data.DbType.String, strStationID);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];

        }
        /// <summary>
        /// 删除指定的工作站
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strStationID"></param>
        /// <returns></returns>
        public static int DeleteWorkStations ( string strStationID )
        {
            string strStoreProcedure = "DeleteWorkStations";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@nvcStationID", System.Data.DbType.String, strStationID);

            return osdDataBase.ExecuteNonQuery (odbCommand);
        }
        /// <summary>
        /// 保存工作站信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="oWorkStations"></param>
        /// <returns></returns>
        public static int SaveWorkStations ( WorkStations oWorkStations )
        {
            string strStoreProcedure = "SaveWorkStations";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@nvcStationID", System.Data.DbType.String, oWorkStations.StationID);
            osdDataBase.AddInParameter (odbCommand, "@nvcStationPostion", System.Data.DbType.String, oWorkStations.StationPostion);
            osdDataBase.AddInParameter (odbCommand, "@iStatus", System.Data.DbType.Int16, oWorkStations.Status);
            osdDataBase.AddInParameter (odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oWorkStations.AddDate);
            osdDataBase.AddInParameter (odbCommand, "@nvcRemark", System.Data.DbType.String, oWorkStations.Remark);
            osdDataBase.AddInParameter (odbCommand, "@nvcStationType", System.Data.DbType.String, oWorkStations.StationType);
            osdDataBase.AddInParameter (odbCommand, "@guDormID", System.Data.DbType.Guid, oWorkStations.DormID);

            return osdDataBase.ExecuteNonQuery (odbCommand);

        }

        /// <summary>
        /// 获取所有的工作站信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strStationID"></param>
        /// <returns></returns>
        public static DataTable GetAllWorkStations ( )
        {
            string strStoreProcedure = "GetAllWorkStations";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            return osdDataBase.ExecuteDataSet (odbCommand).Tables[0];

        }

    }
}

