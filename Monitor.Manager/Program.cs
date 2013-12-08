using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Monitor.Manager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMessage());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = "";
            string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + Environment.NewLine;

            Exception error = e.Exception as Exception;
            if (error != null)
            {
                str = string.Format(strDateInfo + "异常类型：{0}{3}异常消息：{1}{3}异常信息：{2}{3}",
                     error.GetType().Name, error.Message, error.StackTrace, Environment.NewLine);
            }
            else
            {
                str = string.Format("应用程序线程错误:{0}{1}", e, Environment.NewLine);
            }

            writeLog(str);

            MessageBox.Show("发生致命错误，请及时联系作者！\r\n错误信息：" + e.Exception.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = "";
            Exception error = e.ExceptionObject as Exception;

            string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + Environment.NewLine;
            if (error != null)
            {
                str = string.Format(strDateInfo + "Application UnhandledException:{0};{2}堆栈信息:{1}{2}", error.Message, error.StackTrace, Environment.NewLine);
            }
            else
            {
                str = string.Format("Application UnhandledError:{0}{1}", e, Environment.NewLine);
            }

            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            writeLog(str);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="str"></param>
        static void writeLog(string str)
        {
            string ErrPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ErrLog");

            if (!Directory.Exists(ErrPath))
            {
                Directory.CreateDirectory(ErrPath);
            }

            string ErrFile = Path.Combine(ErrPath, "ErrLog.txt");

            using (StreamWriter sw = new StreamWriter(ErrFile, true))
            {
                sw.WriteLine(str);
                sw.WriteLine("---------------------------------------------------------" + Environment.NewLine);
                sw.Close();
            }
        }
    }
}
