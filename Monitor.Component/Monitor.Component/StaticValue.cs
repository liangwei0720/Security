using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace Monitor.Component
{
    #region 静态变量
    public class StaticValue
    {
        //定位时用：查询多少分钟内上传的记录
        public static double findTime = double.Parse (ConfigurationManager.AppSettings["FindTime"].ToString ( ));

        //非法出入时用：多长时间没有检测到记录且不是正常离开时示为非法出入
        public static double warnTime = double.Parse (ConfigurationManager.AppSettings["WarnTime"].ToString ( ));

        //本栋楼要监测的所有标签号
        public static string labelMacs = ConfigurationManager.AppSettings["LabelMacs"].ToString ( );

        //每隔多少秒检测已拆掉的标签（由基站传入已拆信号）
        public static int destroyTime = int.Parse (ConfigurationManager.AppSettings["DestroyTime"].ToString ( ));

        //每隔多少秒检测非法出入的标签（由基站是否收到信号判断）
        public static int lawlessTime = int.Parse (ConfigurationManager.AppSettings["LawlessTime"].ToString ( ));

        //每隔多少秒检测不到标签信息则认为是非法出入
        public static double lawlessOutTime = double.Parse (ConfigurationManager.AppSettings["LawlessOutTime"].ToString ( ));

        //门口用于检测进出的基站编号
        public static string basicApMac = ConfigurationManager.AppSettings["ApMac"].ToString ( );

        //离门口最近的基站
        public static string nearestApMac = ConfigurationManager.AppSettings["NearestApMac"].ToString ( );

        //每隔多少秒检测正常出入的标签
        public static int listenTime = int.Parse (ConfigurationManager.AppSettings["ListenTime"].ToString ( ));

        //当基站信号小于多少则认为已经到达基站附近，视为即将出入
        public static int signalLimit = int.Parse (ConfigurationManager.AppSettings["SignalLimit"].ToString ( ));

        //当基站信号小于多少则认为已经到达基站附近，视为即将出入
        public static int delayTime = int.Parse (ConfigurationManager.AppSettings["DelayTime"].ToString ( ));

        /// <summary>
        /// 标签的当前状态
        /// </summary>
        public enum CurrentStatus
        {
            正常进入 = 0,
            正常离开 = 1,
            非法进入 = 2,
            非法离开 = 3,
            等待进入 = 4,
            等待离开 = 5,
            报警 = 6,
            已损坏 = 7
        }
        /// <summary>
        /// 标签状态定义
        /// </summary>
        public enum LabelStatus
        {
            正常 = 0,
            挂失 = 1,
            已分配 = 2,
            已损坏 = 3
        }

        /// <summary>
        /// 工作站接口类型
        /// </summary>
        public enum WorkStationType
        {
            RJ45 = 0
        }
    }
    #endregion
}
