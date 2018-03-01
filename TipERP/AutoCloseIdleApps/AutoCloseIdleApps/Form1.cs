using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoCloseIdleApps
{
    public partial class Form1 : Form
    {
        public int Idle_time = 0;
        public enum MonitorState : int
        {
            MONITOR_ON = -1,
            MONITOR_OFF = 2,
            MONITOR_STANBY = 1
        };

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 調用windows API獲取鼠標鍵盤空閒時間
        /// </summary>
        /// <param name="plii"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        /// <summary>
        /// 獲取鼠標鍵盤空閒時間
        /// </summary>
        /// <returns></returns>
        public static long GetIdleTick()
        {
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = Marshal.SizeOf(lastInputInfo);
            if (!GetLastInputInfo(ref lastInputInfo)) return 0;
            return Environment.TickCount - (long)lastInputInfo.dwTime;
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct LASTINPUTINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwTime;
        }
        public int WM_SYSCOMMAND = 0x0112;
        public int SC_MONITORPOWER = 0xF170;
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetIdleTick() / 1000 >= Idle_time)//閒置??秒
            {
                SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, (int)MonitorState.MONITOR_OFF);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBox1.Text, out Idle_time);
                timer1.Interval = Idle_time * 1000;//設定計時器幾毫秒執行一次
                timer1.Enabled = true;//打開器
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
