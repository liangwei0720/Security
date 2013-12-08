using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monitor.Component.Model;
using Monitor.Component.DAL;

namespace Monitor.Component.BLL
{
    public class ServerManager
    {
        /// <summary>
        /// 获取指定的服务器信息
        /// </summary>
        /// <param name="intServerID"></param>
        /// <returns></returns>
        public static Server GetServer ( int intServerID )
        {
            return ServerData.GetServer (intServerID);
        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="guDormID"></param>
		/// <returns></returns>
		public static Server GetServerByDormID (Guid guDormID)
		{
			return ServerData.GetServerByDormID( guDormID );
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="guDormID"></param>
		/// <returns></returns>
		public static List<Server> GetServersByDormID (Guid guDormID)
		{
			return ServerData.GetServersByDormID( guDormID );
		}
        /// <summary>
        /// 删除指定的服务器
        /// </summary>
        /// <param name="intServerID"></param>
        public static void DeleteServer ( int intServerID )
        {
             ServerData.DeleteServer (intServerID);
        }
        /// <summary>
        /// 保存服务器信息
        /// </summary>
        /// <param name="oServer"></param>
        public static void SaveServer ( Server oServer )
        {
            ServerData.SaveServer (oServer);
        }
        /// <summary>
        /// 获取所有服务器信息
        /// </summary>
        /// <returns></returns>
        public static List<Server> GetAllServer ( )
        {
            return ServerData.GetAllServer ( );
        }
    }
}
