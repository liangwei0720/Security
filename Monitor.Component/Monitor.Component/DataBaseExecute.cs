using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NGUSoft.Framework.DataAccess;
using System.Data;
using Monitor.Component.Model;

namespace Monitor.Component
{
    public class DataExecute
    {
        /// <summary>
        /// 数据库操作对象 
        /// </summary>
        protected DataManager dm = new DataManager ("ConnStr");

        protected static string SqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr"].ToString ( );

       
        #region 实例化接口
        /// <summary>
        /// 实例化接口
        /// </summary>
        private static DataExecute dbe = null;
        public static DataExecute Instance
        {
            get
            {
                if (dbe == null)
                {
                    dbe = new DataExecute ( );
                }
                return dbe;
            }
        }
        #endregion
    }
}
