using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;

namespace Launcher
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
            Application.Run(new fmLauncher());
        }

        //啟動應用程式
        public static int StartProcess(string ProcessName)
        {
            int pId = 0;

            try
            {
                pId = Process.Start(ProcessName).Id;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return pId;
        }

        //關閉應用程式
        public static void CloseProcess(int pId)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach (Process p in ps)
                {
                    if (p.Id == pId)
                    {
                        Console.WriteLine(p.Id);
                        p.CloseMainWindow();
                        p.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //強制關閉應用程式
        public static void KillProcess(int pId)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach (Process p in ps)
                {
                    if (p.Id == pId)
                        p.Kill();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //判斷應用程式是否執行中
        public static bool IsProcessExist(int pId)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach (Process p in ps)
                {   
                    if (p.Id == pId && p.Id != 0)
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
