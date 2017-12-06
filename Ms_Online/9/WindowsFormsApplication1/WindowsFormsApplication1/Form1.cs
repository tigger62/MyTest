using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
                try
            {
                wc.Encoding = Encoding.UTF8;

                NameValueCollection nc = new NameValueCollection();
                nc["id"] = "aaa";
                nc["pw"] = "bbb";

                byte[] bResult = wc.UploadValues("http://192.168.100.145", nc);

                string resultXML = Encoding.UTF8.GetString(bResult);
            }
            catch (WebException ex)
            {
                throw new Exception("無法連接遠端伺服器");
            }
        }
    }
}
