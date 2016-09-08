using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quikr_Multiple_Posts
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtun.Text.Trim() != String.Empty || txtmobno.Text.Trim() != String.Empty)
            {
                this.Hide();
                Form1 fm1 = new Form1();
                fm1.valuefrom(txtun.Text);
                fm1.valuefrom1(txtmobno.Text);
                fm1.Show();
                //fm1.mohan = textBox1.Text.ToString();
            }
        }

        private void txtun_TextChanged(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtun.Text, pattern))
            {
                lblun.Text = "Valid email address";
                lblun.ForeColor = Color.Green;
            }
            else
            {
                lblun.Text = "Not a valid email address";
                lblun.ForeColor = Color.Red;
            }
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            txtun.SelectionStart = txtun.Text.Length;

        }
    }
}
