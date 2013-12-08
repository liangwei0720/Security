using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace Monitor.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    public class Service : IService1
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private static string webRoot = HttpContext.Current.Server.MapPath("~/");

        public bool SendMessageToServer(string message)
        {            
            DateTime dateTimeNow = DateTime.Now;
            string fileName = System.IO.Path.Combine(Dir.CheckDir(webRoot, dateTimeNow.Year.ToString(), dateTimeNow.Month.ToString()), dateTimeNow.Day.ToString("dd") + ".txt");

            System.IO.File.WriteAllText(fileName, message);
            return true;
        }
    }

    public class Dir
    {
        public static string CheckDir(string root, string year, string month)
        {
            string returnPath = System.IO.Path.Combine(root, year);
            if (!System.IO.Directory.Exists(returnPath))
            {
                System.IO.Directory.CreateDirectory(returnPath);
            }
            returnPath = System.IO.Path.Combine(returnPath, month);


            if (!System.IO.Directory.Exists(returnPath))
            {
                System.IO.Directory.CreateDirectory(returnPath);
            }

            return returnPath;
        }
    }
}
