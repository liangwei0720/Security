using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Configuration;

namespace Monitor.Manager
{
    public partial class FrmMessage : Form
    {
        public FrmMessage()
        {
            InitializeComponent();
        }

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0}接收到消息:{1}", DateTime.Now.ToString("HH:mm:ss"), LogWriter.LogMessage);
            int x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width - 10;
            int y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height - 10;
            this.SetDesktopLocation(x, y);

            Win32.SetWindowPos(this.Handle, 100, Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - 30, 50, 50, 1);
            Win32.AnimateWindow(this.Handle, 500, Win32.AW_VER_NEGATIVE);

        }
    }

    public class LogWriter
    {
        public static object lockObj = new object();

        public static string LogFolder
        {
            get
            {
                string logFolder = ConfigurationManager.AppSettings["ReadFolder"];

                if (string.IsNullOrEmpty(logFolder))
                {
                    logFolder = "Log";
                }

                if (string.IsNullOrEmpty(Path.GetPathRoot(logFolder)))
                {
                    string workingDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                    logFolder = Path.Combine(workingDirectory, logFolder);
                }
                return logFolder;
            }
        }



        public static string LogMessage
        {
            get
            {
                string fileName = string.Format("{0}.txt", DateTime.Now.ToString("yyyyMMdd"));

                string logFolder = LogFolder;
                if (!Directory.Exists(logFolder) || !File.Exists(Path.Combine(logFolder, fileName)))
                {
                    return string.Empty;
                }
                string[] lines = System.IO.File.ReadAllLines(Path.Combine(logFolder, fileName));

                return lines[lines.Length - 1];
            }
        }

    }

    public class Win32
    {
        public const Int32 AW_HOR_POSITIVE = 0x00000001;
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;
        public const Int32 AW_VER_POSITIVE = 0x00000004;
        public const Int32 AW_VER_NEGATIVE = 0x00000008;
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_HIDE = 0x00010000;
        public const Int32 AW_ACTIVATE = 0x00020000;
        public const Int32 AW_SLIDE = 0x00040000;
        public const Int32 AW_BLEND = 0x00080000;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(
            IntPtr hwnd, // handle to window    
            int dwTime, // duration of animation    
            int dwFlags // animation type    
        );
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SetWindowPos(
            IntPtr hwnd,
            int hWndInsertAfter,
            int x,
            int y,
            int cx,
            int cy,
            int wFlags
        );

    }
}
