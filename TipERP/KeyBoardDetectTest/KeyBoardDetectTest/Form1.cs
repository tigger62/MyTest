using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardDetectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GlobalKeyboardHook gHook;
        private void Form1_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_keyDown);
            foreach (Keys key in Enum.GetValues(typeof(keys)))
                gHook.HookedKeys.Add(key);
        }

        public void gHook_keyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text += ((char)e.KeyValue).ToString();
        }

        private void btnHook_Click(object sender, EventArgs e)
        {
            gHook.hook();
        }

        private void btnUnhook_Click(object sender, EventArgs e)
        {
            gHook.unhook();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
        }
    }
}
