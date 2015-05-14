using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPAddressControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ipAddressControl1_IPAddressChanged(object sender, EventArgs e)
        {
            label1.Text = ipAddressControl1.IPAddress.ToString();
        }
    }
}
