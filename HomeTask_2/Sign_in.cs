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
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void tb_name_Enter(object sender, EventArgs e)
        {
            if (tb_name.Text == "Dunay Gudratli")
            {
                tb_name.Text = "";
                tb_name.ForeColor = Color.Black;
            }
        }

        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                tb_name.Text = "Dunay Gudratli";
                tb_name.ForeColor = Color.Gray;
            }
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

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "Dunay Gudratli" || tb_username.Text == "Kudratli" || tb_password.Text == "" || tb_passwordConfirm.Text == "") MessageBox.Show("Fill information fully!");
            else if (tb_name.Text.IndexOf(' ') == -1) MessageBox.Show("Full name is incorrect!\nExample: Dunay Gudratli", "Error");
            else
            {
                if (tb_password.Text == tb_passwordConfirm.Text)
                {

                    lbl_passwordConfirm.Text = "Confirm password";
                    lbl_passwordConfirm.ForeColor = Color.White;
                    lbl_errorPassword.Visible = false;
                    StreamReader sr = new StreamReader(@"database\login.dat");
                    String str = null;
                    bool key = true;
                    while ((str = sr.ReadLine()) != null)
                    {
                        int i = str.IndexOf('-');
                        string username = str.Substring(0, i);
                        if (tb_username.Text == username) key = false; break;
                    }
                    sr.Close();
                    if (key)
                    {
                        lbl_username.Text = "Username";
                        lbl_username.ForeColor = Color.White;
                        lbl_errorUsername.Visible = false;
                        String add = tb_username.Text + '-' + tb_password.Text + '|' + tb_name.Text + "\n";
                        File.AppendAllText(@"database\login.dat", add);
                        MessageBox.Show("Successfully signed in!");
                        StreamWriter sw = new StreamWriter(@"database\users\" + tb_username.Text + ".dat");
                        sw.Close();
                        this.Hide();
                    }
                    else
                    {
                        lbl_errorUsername.Visible = true;
                        lbl_username.Text = "Username *";
                        lbl_username.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbl_errorPassword.Visible = true;
                    lbl_passwordConfirm.Text = "Confirm password *";
                    lbl_passwordConfirm.ForeColor = Color.Red;
                }
            }
            
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }
    }
}
