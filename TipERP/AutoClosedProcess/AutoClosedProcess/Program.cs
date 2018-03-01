using System;
using System.Security.Principal;
using System.Diagnostics;


namespace AutoClosedProcess
{
    class Program
    {        
        static void Main(string[] args) {
            if ( args == null || args.Length < 2)
            {
                Console.WriteLine("please input process and program name..");
                Console.WriteLine("Porcess：");
                Console.WriteLine("s: start porcess.");
                Console.WriteLine("c: close porcess.");
                return;
            }

            Program s = new Program();
            string sw, ProcessName, user;

            
            sw = args[0].Length > 0 ? args[0] : "";
            user = WindowsIdentity.GetCurrent().Name;
            ProcessName = args[1].Length > 1 ? args[1] : "";

            switch (sw.ToUpper())
            {
                //Close the specified process.
                case "S":
                    s.StartProcess(ProcessName);
                    break;
                //Close the specified process.
                case "C":
                    s.CloseProcess(ProcessName);
                    break;
                default:
                    s.IsProcessExist(ProcessName);
                    break;
            }
        }

        //啟動應用程式
        private void StartProcess(string ProcessName)
        {
            try
            {
                Process.Start(ProcessName);
                Console.WriteLine(Process.Start(ProcessName).Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //關閉應用程式
        private void CloseProcess(string ProcessName)
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
        private void KillProcess(string ProcessName, int ProcessID)
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
        private bool IsProcessExist(string ProcessName)
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