using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monitor.Component.Model;
using Monitor.Component.DAL;

namespace Monitor.Component.BLL
{
  public  class AdminManage
    {
        /// <summary>
        /// 根据AdminID获取Admin信息
        /// </summary>
        /// <param name="intAdmin"></param>
        /// <returns></returns>
        public static Admin GetAdmin ( int intAdmin )
        {
            return AdminDAL.GetAdmin (intAdmin);
        }
        /// <summary>
        /// 删除一个管理员
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="intAdmin"></param>
        public static void DeleteAdmin (  int intAdmin )
        {
            AdminDAL.DeleteAdmin (intAdmin);
        }
        /// <summary>
        /// 添加一个管理员
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="oAdmin"></param>
        public static void SaveAdmin (Admin oAdmin )
        {
            AdminDAL.SaveAdmin (oAdmin);
        }

        public static Admin GetAdmin ( string loginName, string landPWD )
        {
            return AdminDAL.GetAdmin (loginName, landPWD);
        }
        /// <summary>
        /// 根据AdminID获取Admin信息
        /// </summary>
        /// <param name="intAdmin"></param>
        /// <returns></returns>
        public static List<Admin> GetAllAdmin ( )
        {
            return AdminDAL.GetAllAdmin ( );
        }
    }
}
