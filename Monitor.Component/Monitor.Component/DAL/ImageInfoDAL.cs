using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using NGUSoft.Framework.DataAccess;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using Monitor.Component.Model;

namespace Monitor.Component.DAL
{
    public class ImageInfoDAL : DataExecute
    {
        /// <summary>
        /// 获取图片信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetImageInfo ( int ID )
        {
            string sql = @"	SELECT *
							FROM T_ImageInfo 
							WHERE [ID]=@ID";

            SqlParameter[] para = new SqlParameter[] { 
								new SqlParameter("ID",DbType.Int32,ID)
			};

            return dm.ExecuteDataTable (sql, para);
        }

        /// <summary>
        /// 获取图片信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetAllImageInfo ( string condition )
        {
            string sql = @"	SELECT * FROM T_ImageInfo where " + condition + "	Order by OrderNumber";

            return dm.ExecuteDataTable (sql);
        }

        /// <summary>
        /// 保存图片信息
        /// </summary>
        /// <param name="oT_ImageInfo"></param>
        public void SaveImageInfo ( ImageInfo oT_ImageInfo )
        {
            string strStoreProcedure = "SaveT_ImageInfo";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@ImageData", System.Data.DbType.Binary, oT_ImageInfo.ImageData);
            osdDataBase.AddInParameter (odbCommand, "@ImageName", System.Data.DbType.String, oT_ImageInfo.ImageName);
            osdDataBase.AddInParameter (odbCommand, "@UpdateTime", System.Data.DbType.DateTime, oT_ImageInfo.UpdateTime);
            osdDataBase.AddInParameter (odbCommand, "@UpdatePerson", System.Data.DbType.String, oT_ImageInfo.UpdatePerson);
            osdDataBase.AddInParameter (odbCommand, "@OrderNumber", System.Data.DbType.Int32, oT_ImageInfo.OrderNumber);
            osdDataBase.AddParameter (odbCommand, "@ID", System.Data.DbType.Int32, ParameterDirection.InputOutput, null, DataRowVersion.Default, oT_ImageInfo.ID);

            osdDataBase.ExecuteNonQuery (odbCommand);
            oT_ImageInfo.ID = (int)osdDataBase.GetParameterValue (odbCommand, "@ID");

        }

        /// <summary>
        /// 删除一个图片信息
        /// </summary>
        /// <param name="intID"></param>
        public void DeleteT_ImageInfo ( int intID )
        {
            string strStoreProcedure = "DeleteT_ImageInfo";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@ID", System.Data.DbType.Int32, intID);

            osdDataBase.ExecuteNonQuery (odbCommand);
        }


        /// <summary>
        /// 保存图片信息
        /// </summary>
        /// <param name="oT_ImageInfo"></param>
        public void SaveImageInfo ( ImageInfo oT_ImageInfo, string clientIPConnection )
        {
            string strStoreProcedure = "SaveT_ImageInfo";
            SqlDatabase osdDataBase = new SqlDatabase (clientIPConnection);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@bIsFirst", System.Data.DbType.Boolean, oT_ImageInfo.IsFirst);
            osdDataBase.AddInParameter (odbCommand, "@ImageData", System.Data.DbType.Binary, oT_ImageInfo.ImageData);
            osdDataBase.AddInParameter (odbCommand, "@ImageName", System.Data.DbType.String, oT_ImageInfo.ImageName);
            osdDataBase.AddInParameter (odbCommand, "@UpdateTime", System.Data.DbType.DateTime, oT_ImageInfo.UpdateTime);
            osdDataBase.AddInParameter (odbCommand, "@UpdatePerson", System.Data.DbType.String, oT_ImageInfo.UpdatePerson);
            osdDataBase.AddInParameter (odbCommand, "@OrderNumber", System.Data.DbType.Int32, oT_ImageInfo.OrderNumber);
            osdDataBase.AddParameter (odbCommand, "@ID", System.Data.DbType.Int32, ParameterDirection.InputOutput, null, DataRowVersion.Default, oT_ImageInfo.ID);

            osdDataBase.ExecuteNonQuery (odbCommand);
            oT_ImageInfo.ID = (int)osdDataBase.GetParameterValue (odbCommand, "@ID");

        }

    }
}
