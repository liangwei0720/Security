using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
    public class InOutInfoManager
    {
        public static InOutInfo GetInOutInfo ( Guid guInOutID )
        {
            return InOutInfoData.GetInOutInfo (guInOutID);
        }
        public static void DeleteInOutInfo ( Guid guInOutID )
        {
            InOutInfoData.DeleteInOutInfo (guInOutID);
        }

        public static void DeleteInOutInfo ( long InOutID, string ClientIPConnection )
        {
            if (string.IsNullOrEmpty (ClientIPConnection))
            {
                return;
            }
            InOutInfoData.DeleteInOutInfo (InOutID, ClientIPConnection);
        }

        public static void SaveInOutInfo ( InOutInfo oInOutInfo )
        {
            InOutInfoData.SaveInOutInfo (oInOutInfo);

        }

        /// <summary>
        /// 从指定的客户端获取出入记录
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="clientSqlConnectionString"></param>
        /// <returns></returns>
        public static List<InOutInfo> GetListByCondition ( string condition, string clientSqlConnectionString )
        {
            List<InOutInfo> oList = new List<InOutInfo> ( );

            if (string.IsNullOrEmpty (condition))
            {
                condition = "1=1";
            }

            DataTable dt = InOutInfoData.GetListByCondition (condition, clientSqlConnectionString);

            foreach (DataRow row in dt.Rows)
            {
                oList.Add (ParseModel (row));
            }

            return oList;
        }

        public static List<InOutInfo> GetListByCondition ( string condition )
        {
            List<InOutInfo> oList = new List<InOutInfo> ( );

            if (string.IsNullOrEmpty (condition))
            {
                condition = "1=1";
            }

            DataTable dt = InOutInfoData.GetListByCondition (condition);

            foreach (DataRow row in dt.Rows)
            {
                oList.Add (ParseModel (row));
            }

            return oList;
        }

        private static InOutInfo ParseModel ( DataRow row )
        {
            InOutInfo oInOutInfo = new InOutInfo ( );
            oInOutInfo.GUInOutID = row["guInOutID"] is DBNull ? Guid.Empty : (Guid)row["guInOutID"];
            oInOutInfo.InOutID = row["InOutID"] is DBNull ? 0 : (long)row["InOutID"];
            oInOutInfo.InOutTime = row["InOutTime"] is DBNull ? DateTime.Now : (DateTime)row["InOutTime"];
            oInOutInfo.CurrentStatus = row["CurrentStatus"] is DBNull ? 0 : (int)row["CurrentStatus"];
            oInOutInfo.LabelCode = row["LabelCode"] is DBNull ? "" : (string)row["LabelCode"];
            oInOutInfo.DormID = row["guDormID"] is DBNull ? Guid.Empty : (Guid)row["guDormID"];
            oInOutInfo.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : (DateTime)row["dtAddDate"];

            return oInOutInfo;
        }

        public static DataTable GetInOurByCondition ( string condition )
        {
            if (string.IsNullOrEmpty (condition))
            {
                condition = " 1=1";
            }
            return InOutInfoData.GetInOurByCondition (condition);
        }
    }
}
