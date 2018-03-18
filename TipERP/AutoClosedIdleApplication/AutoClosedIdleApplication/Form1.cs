using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Windows.Forms; 


namespace AutoClosedIdleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        GlobalKeyboardHook gHook;
        //取得使用者帳號
        String user = WindowsIdentity.GetCurrent().Name;
        string sw, ProcessName;


        private void Form1_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_keyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
        }


        public void gHook_keyDown(object sender, KeyEventArgs e)
        {
            //textBox1.Text += ((char)e.KeyValue).ToString();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            gHook.hook();
            if(tbxAppName.Text.Length > 0) { Program.StartProcess(tbxAppName.Text); }
            switch (sw.ToUpper())
            {
                //Close the specified process.
                case "S":
                    Program.StartProcess(tbxAppName.Text);
                    break;
                //Close the specified process.
                case "C":
                    Program.CloseProcess(ProcessName);
                    break;
                default:
                    Program.IsProcessExist(ProcessName);
                    break;
            }
        }
    }
}
