using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monitor.Component.Model;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

namespace Monitor.Component.DAL
{
    public class AdminDAL : DataExecute
    {
        /// <summary>
        /// 根据AdminID获取Admin信息
        /// </summary>
        /// <param name="intAdmin"></param>
        /// <returns></returns>
        public static Admin GetAdmin ( int intAdmin )
        {
            string strStoreProcedure = "GetAdmin";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);
            DataSet odsData;
            DataTable odtTable;
            Admin oAdmin = null;

            osdDataBase.AddInParameter (odbCommand, "@iAdmin", System.Data.DbType.Int32, intAdmin);

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            odtTable = odsData.Tables[0];
            if (odtTable.Rows.Count == 1)
            {
                oAdmin = new Admin ( );
                oAdmin.AdminID = odtTable.Rows[0]["iAdmin"] is DBNull ? 0 : (int)odtTable.Rows[0]["iAdmin"];
                oAdmin.LoginName = odtTable.Rows[0]["vcLoginName"] is DBNull ? "" : (string)odtTable.Rows[0]["vcLoginName"];
                oAdmin.PWD = odtTable.Rows[0]["vcPWD"] is DBNull ? "" : (string)odtTable.Rows[0]["vcPWD"];
            }
            return oAdmin;
        }
        /// <summary>
        /// 删除一个管理员
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="intAdmin"></param>
        public static void DeleteAdmin ( int intAdmin )
        {
            string strStoreProcedure = "DeleteAdmin";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@iAdmin", System.Data.DbType.Int32, intAdmin);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }
        /// <summary>
        /// 添加一个管理员
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="oAdmin"></param>
        public static void SaveAdmin ( Admin oAdmin )
        {
            string strStoreProcedure = "SaveAdmin";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@vcLoginName", System.Data.DbType.String, oAdmin.LoginName);
            osdDataBase.AddInParameter (odbCommand, "@vcPWD", System.Data.DbType.String, oAdmin.PWD);
            osdDataBase.AddParameter (odbCommand, "@iAdmin", System.Data.DbType.Int32, ParameterDirection.InputOutput, null, DataRowVersion.Default, oAdmin.AdminID);

            osdDataBase.ExecuteNonQuery (odbCommand);
            oAdmin.AdminID = (int)osdDataBase.GetParameterValue (odbCommand, "@iAdmin");
        }

        public static Admin GetAdmin ( string loginName, string landPWD )
        {
            string strStoreProcedure = "GetLoginAdmin";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);
            DataSet odsData;
            DataTable odtTable;
            Admin oAdmin = null;

            osdDataBase.AddInParameter (odbCommand, "@vcLoginName", System.Data.DbType.String, loginName);
            osdDataBase.AddInParameter (odbCommand, "@vcPWD", System.Data.DbType.String, landPWD);

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            odtTable = odsData.Tables[0];
            if (odtTable.Rows.Count == 1)
            {
                oAdmin = new Admin ( );
                oAdmin.AdminID = odtTable.Rows[0]["iAdmin"] is DBNull ? 0 : (int)odtTable.Rows[0]["iAdmin"];
                oAdmin.LoginName = odtTable.Rows[0]["vcLoginName"] is DBNull ? "" : (string)odtTable.Rows[0]["vcLoginName"];
                oAdmin.PWD = odtTable.Rows[0]["vcPWD"] is DBNull ? "" : (string)odtTable.Rows[0]["vcPWD"];
            }
            return oAdmin;
        }
        /// <summary>
        /// 根据AdminID获取Admin信息
        /// </summary>
        /// <param name="intAdmin"></param>
        /// <returns></returns>
        public static List<Admin> GetAllAdmin ( )
        {
            string strStoreProcedure = "GetAllAdmin";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);
            DataSet odsData;
            DataTable odtTable;

            List<Admin> olist = new List<Admin> ( );
           
            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            odtTable = odsData.Tables[0];
            foreach (DataRow row in odtTable.Rows)
            {
                olist.Add (new Admin ( )
                {
                    AdminID = row["iAdmin"] is DBNull ? 0 : (int)row["iAdmin"],
                    LoginName = row["vcLoginName"] is DBNull ? "" : (string)row["vcLoginName"],
                    PWD = row["vcPWD"] is DBNull ? "" : (string)row["vcPWD"]
                });

            }
            return olist;
        }

    }
}
