using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == "Kudratli")
            {
                tb_username.Text = "";
                tb_username.ForeColor = Color.Black;
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Kudratli";
                tb_username.ForeColor = Color.Gray;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "Kudratli" || tb_password.Text == "") MessageBox.Show("Fill information fully!");
            else
            {
                StreamReader sr = new StreamReader(@"database\login.dat");
                String str = null;
                while ((str = sr.ReadLine()) != null)
                {
                    int i = str.IndexOf('-');
                    int ii = str.IndexOf('|');
                    ii -= i + 1;
                    string username = str.Substring(0, i);
                    string password = str.Substring(i + 1, ii);
                    if (tb_username.Text == username && tb_password.Text == password)
                    {
                        Main m = new Main(username);
                        m.Show();
                        this.Hide();
                    }
                    else lbl_errorMessage.Visible = true;
                }
                sr.Close();
            }
            
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            Sign_in si = new Sign_in();
            si.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btn_login.Focus();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
