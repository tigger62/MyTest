using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;

namespace AutoClosedIdleApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        //啟動應用程式
        public static void StartProcess(string ProcessName)
        {
            int processId;

            try
            {
                processId = Process.Start(ProcessName).Id;
                Console.WriteLine(processId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //關閉應用程式
        public static void CloseProcess(string ProcessName)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach (Process p in ps)
                {
                    if (p.ProcessName == ProcessName)
                    {
                        Console.WriteLine(p.Id);
                        p.CloseMainWindow();
                        p.Close();
                        //p.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //強制關閉應用程式
        public static void KillProcess(string ProcessName, int ProcessID)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach (Process p in ps)
                {
                    if (p.ProcessName == ProcessName && p.Id == ProcessID)
                    {
                        p.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //判斷應用程式是否執行中
        public static bool IsProcessExist(string ProcessName)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach (Process p in ps)
                {
                    if (p.ProcessName == ProcessName)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
    }
}
