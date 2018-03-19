using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Launcher
{
    public partial class fmLauncher : Form
    {
        public fmLauncher()
        {
            InitializeComponent();
        }

        GlobalKeyboardHook gHook;
        static int pId = 0;
        static DateTime beginTime;

        private void fmLauncher_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_keyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);

            lblShowPID.Text = "";
            label5.Text = "";
        }


        public void gHook_keyDown(object sender, KeyEventArgs e)
        {
            label5.Text = ((char)e.KeyValue).ToString();
            beginTime = DateTime.Now.AddMinutes(Convert.ToInt32(tbxSetIdleTime.Text));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbxSetAppName.Text.Length > 0)
            {
                pId = Program.StartProcess(tbxSetAppName.Text);
                if (pId == 0)
                {
                    lblShowPID.Text = "程式不存在";
                    return;
                }

                gHook.hook();
                lblShowPID.Text = "PID: " + pId.ToString() + DateTime.Now;
                beginTime = DateTime.Now.AddMinutes(Convert.ToInt32(tbxSetIdleTime.Text));

                TimerCallback callback = new TimerCallback(TimerTask);
                System.Threading.Timer timer = new System.Threading.Timer(callback, null, 1000, 1000);
            }
        }


        private void fmLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            while (Program.IsProcessExist(pId))
            {
                Program.CloseProcess(pId);
                Program.KillProcess(pId);
            }
            gHook.unhook();

            lblShowPID.Text = "";
            label5.Text = "";
            Application.Exit();

        }

        private static void TimerTask(object obj)
        {
            Thread.Sleep(1000);
            if (beginTime.CompareTo(DateTime.Now) == 1)
                Program.KillProcess(pId);
        }
    }

}
