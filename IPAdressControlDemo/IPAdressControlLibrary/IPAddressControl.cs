using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IPAddressControlLibrary
{
    [DefaultEvent("IPAddressChanged")]
    [DefaultProperty("IPAddress")]
    [DefaultBindingProperty("IPAddress")]
    public partial class IPAddressControl: UserControl
    {
        private IPAddress ipAddress = new IPAddress(new byte[] { 0, 0, 0, 0 });

        [Category("Основные события")]
        public event EventHandler IPAddressChanged;

        public IPAddressControl()
        {
            InitializeComponent();
            Update();
        }

        private void UpdateControls()
        {
            byte[] address = ipAddress.GetAddressBytes();
            textBox1.Text = address[0].ToString();
            textBox2.Text = address[1].ToString();
            textBox3.Text = address[2].ToString();
            textBox4.Text = address[3].ToString();
        }

        protected void OnIPAddressChange()
        {
            if (IPAddressChanged != null)
                IPAddressChanged(this, EventArgs.Empty);
        }

        [DefaultValue(new byte[] { 0, 0, 0, 0 })]
        [Bindable(true)]
        [Category("Основные свойства")]
        [Description("Текущий IP-адрес")]
        public IPAddress IPAddress
        {
            get
            {
                return ipAddress;
            }
            set
            {
                bool changed = !ipAddress.Equals(value);
                ipAddress = value;
                if (changed)
                    OnIPAddressChange();
                UpdateControls();
            }
        }

        private void textBoxChange(TextBox textBox, int i)
        {
            byte[] ipAddressBytes = ipAddress.GetAddressBytes();

            try
            {
                if (textBox.Text == "") ipAddressBytes[i] = 0;
                else
                    ipAddressBytes[i] = Convert.ToByte(textBox.Text);
                IPAddress = new IPAddress(ipAddressBytes);
                if (textBox.Text.Length == 3) GoToNext(textBox);
            }
            catch (Exception)
            {
                MessageBox.Show("Недопустимое значение. Укажите значение в диапазоне от 0 до 255", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ipAddressBytes[i] = 255;
                IPAddress = new IPAddress(ipAddressBytes);
                textBox.Select();
                textBox.SelectAll();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            byte[] ipAddressBytes = ipAddress.GetAddressBytes();

            if (sender == textBox1)
                textBoxChange(textBox1, 0);
            else if (sender == textBox2)
                textBoxChange(textBox2, 1);
            else if (sender == textBox3)
                textBoxChange(textBox3, 2);
            else
                textBoxChange(textBox4, 3);
        }

        private void GoToPrev(object sender)
        {
            if (sender == textBox2)
            {
                textBox1.Select();
                textBox1.SelectAll();
            }
            if (sender == textBox3)
            {
                textBox2.Select();
                textBox2.SelectAll();
            }
            if (sender == textBox4)
            {
                textBox3.Select();
                textBox3.SelectAll();
            }
        }

        private void GoToNext(object sender)
        {
            if (sender == textBox1)
            {
                textBox2.Select();
                textBox2.SelectAll();
            }
            if (sender == textBox2)
            {
                textBox3.Select();
                textBox3.SelectAll();
            }
            if (sender == textBox3)
            {
                textBox4.Select();
                textBox4.SelectAll();
            }
        }
        
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox_TextChanged(sender, EventArgs.Empty);
                return;
            }

            if (e.KeyData == Keys.Left)
            {
                GoToPrev(sender);
                return;
            }

            if (e.KeyData == Keys.Right)
            {
                GoToNext(sender);
                return;
            }
        }
    }
}
