using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
    public class WorkStationsManager
    {
        /// <summary>
        /// 获取指定的工作站信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strStationID"></param>
        /// <returns></returns>
        public static WorkStations GetWorkStations ( string strStationID )
        {
            DataTable dt = WorkStationsData.GetWorkStations (strStationID);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return ParseModel (dt.Rows[0]);

        }
        /// <summary>
        /// 删除指定的工作站
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strStationID"></param>
        /// <returns></returns>
        public static bool DeleteWorkStations ( string strStationID )
        {
            return WorkStationsData.DeleteWorkStations (strStationID) > 0;
        }
        /// <summary>
        /// 保存工作站信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="oWorkStations"></param>
        /// <returns></returns>
        public static bool SaveWorkStations ( WorkStations oWorkStations )
        {
            return WorkStationsData.SaveWorkStations (oWorkStations) > 0;

        }

        /// <summary>
        /// 获取指定的工作站信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="strStationID"></param>
        /// <returns></returns>
        public static List<WorkStations> GetAllWorkStations ( )
        {
            List<WorkStations> oList = new List<WorkStations> ( );
            DataTable dt = WorkStationsData.GetAllWorkStations ( );

            if (dt.Rows.Count == 0)
            {
                return oList;
            }

            foreach (DataRow row in dt.Rows)
            {
                oList.Add (ParseModel (row));
            }

            return oList;

        }

        /// <summary>
        /// 解析实体
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static WorkStations ParseModel ( DataRow row )
        {
            WorkStations oWorkStations = new WorkStations ( );
            oWorkStations.StationID = row["nvcStationID"] is DBNull ? "" : (string)row["nvcStationID"];
            oWorkStations.StationPostion = row["nvcStationPostion"] is DBNull ? "" : (string)row["nvcStationPostion"];
            oWorkStations.Status = row["iStatus"] is DBNull ? (short)0 : (short)row["iStatus"];
            oWorkStations.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : (DateTime)row["dtAddDate"];
            oWorkStations.Remark = row["nvcRemark"] is DBNull ? "" : (string)row["nvcRemark"];
            oWorkStations.StationType = row["nvcStationType"] is DBNull ? "" : (string)row["nvcStationType"];
            oWorkStations.DormID = row["guDormID"] is DBNull ? Guid.Empty : (Guid)row["guDormID"];

            return oWorkStations;
        }


    }
}
