using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monitor.Component.Model;
using Monitor.Component.DAL;
using System.Data;

namespace Monitor.Component.BLL
{
	public class T_MonitorHistoryManager
	{
		/// <summary>
		/// 获取指定客户端信息
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="ClientIP"></param>
		/// <returns></returns>
		public static DataTable GetT_MonitorHistoryForLocation (string condition , string ClientIP)
		{
			if ( string.IsNullOrEmpty( condition ) )
			{
				condition = " 1 =1 ";
			}
			return T_MonitorHistoryData.GetT_MonitorHistoryForLocation( condition , ClientIP );
		}

		/// <summary>
		/// 获取指定客户端信息
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="ClientIP"></param>
		/// <returns></returns>
		public static List<T_MonitorHistory> GetAllT_MonitorHistoryForLocation (string condition , string ClientIP)
		{
			if ( string.IsNullOrEmpty( condition ) )
			{
				condition = " 1 =1 ";
			}
			DataTable table= T_MonitorHistoryData.GetT_MonitorHistoryForLocation( condition , ClientIP );

			if ( table == null || table.Rows.Count == 0 )
			{
				return null;
			}

			List<T_MonitorHistory> oList = new List<T_MonitorHistory>( );

			foreach ( DataRow row in table.Rows )
			{
				oList.Add( new T_MonitorHistory { APMac = row["APMac"].ToString( ) , ReceiveTime = ( DateTime )row["ReceiveTime"] , SignalStrong = ( int )row["SignalStrong"] } );
			}

			return oList;
		}

		/// <summary>
		/// 获取监控历史信息
		/// </summary>
		/// <param name="HistoryID"></param>
		/// <returns></returns>
		public static T_MonitorHistory GetT_MonitorHistory (int HistoryID)
		{
			return T_MonitorHistoryData.GetT_MonitorHistory( HistoryID );
		}

		/// <summary>
		/// 删除指定监控记录
		/// </summary>
		/// <param name="HistoryID"></param>
		public static void DeleteT_MonitorHistory (int HistoryID)
		{
			T_MonitorHistoryData.DeleteT_MonitorHistory( HistoryID );
		}
		/// <summary>
		/// 保存监控记录
		/// </summary>
		/// <param name="oT_MonitorHistory"></param>
		public static void SaveT_MonitorHistory (T_MonitorHistory oT_MonitorHistory)
		{
			T_MonitorHistoryData.SaveT_MonitorHistory( oT_MonitorHistory );
		}
	}
}
