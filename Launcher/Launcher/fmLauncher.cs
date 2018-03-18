using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void fmLauncher_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_keyDown);
        }


        public void gHook_keyDown(object sender, KeyEventArgs e)
        {
            //textBox1.Text += ((char)e.KeyValue).ToString();
        }
    }

}
