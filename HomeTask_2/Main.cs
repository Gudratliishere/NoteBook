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
    public partial class Main : Form
    {
        String username = null, user = null;
        public Main(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"database\login.dat");
            String str = null;
            while ((str = sr.ReadLine()) != null)
            {
                int i = str.IndexOf('-');
                int ii = str.IndexOf('|');
                int isp = str.IndexOf(' ');
                isp -= ii + 1;
                string username = str.Substring(0, i);
                if (username == this.username)
                {
                    user = str.Substring(ii + 1, isp);
                    break;
                }
            }
            sr.Close();
            string[] names = new string[15];
            lbl_wellcomeUsername.Text = "Wellcome to NoteBook " + user + '!';
            sr = new StreamReader(@"database\users\" + username + ".dat");
            string line = null;
            int k = 0;
            while ((line = sr.ReadLine()) != null)
            {
                names[k] = line;
                k++;
            }

            fillButtons(names);

            sr.Close();
            timer_refresh.Start();
        }

        private void fillButtons (string[] names)
        {
            btn_note1.Text = names[0];
            btn_note2.Text = names[1];
            btn_note3.Text = names[2];
            btn_note4.Text = names[3];
            btn_note5.Text = names[4];
            btn_note6.Text = names[5];
            btn_note7.Text = names[6];
            btn_note8.Text = names[7];
            btn_note9.Text = names[8];
            btn_note10.Text = names[9];
            btn_note11.Text = names[10];
            btn_note12.Text = names[11];
            btn_note13.Text = names[12];
            btn_note14.Text = names[13];
            btn_note15.Text = names[14];

            btn_note1.Visible = (names[0] != null) ? true : false;
            btn_note2.Visible = (names[1] != null) ? true : false;
            btn_note3.Visible = (names[2] != null) ? true : false;
            btn_note4.Visible = (names[3] != null) ? true : false;
            btn_note5.Visible = (names[4] != null) ? true : false;
            btn_note6.Visible = (names[5] != null) ? true : false;
            btn_note7.Visible = (names[6] != null) ? true : false;
            btn_note8.Visible = (names[7] != null) ? true : false;
            btn_note9.Visible = (names[8] != null) ? true : false;
            btn_note10.Visible = (names[9] != null) ? true : false;
            btn_note11.Visible = (names[10] != null) ? true : false;
            btn_note12.Visible = (names[11] != null) ? true : false;
            btn_note13.Visible = (names[12] != null) ? true : false;
            btn_note14.Visible = (names[13] != null) ? true : false;
            btn_note15.Visible = (names[14] != null) ? true : false;
        }

        private void btn_createNote_Click(object sender, EventArgs e)
        {
            New_note nn = new New_note(username);
            nn.Show();
        }

        private void btn_note1_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note1.Text, username);
            en.Show();
        }

        private void btn_note2_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note2.Text, username);
            en.Show();
        }

        private void btn_note3_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note3.Text, username);
            en.Show();
        }

        private void btn_note4_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note4.Text, username);
            en.Show();
        }

        private void btn_note5_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note5.Text, username);
            en.Show();
        }

        private void btn_note6_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note6.Text, username);
            en.Show();
        }

        private void btn_note7_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note7.Text, username);
            en.Show();
        }

        private void btn_note8_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note8.Text, username);
            en.Show();
        }

        private void btn_note9_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note9.Text, username);
            en.Show();
        }

        private void btn_note10_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note10.Text, username);
            en.Show();
        }

        private void btn_note11_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note11.Text, username);
            en.Show();
        }

        private void btn_note12_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note12.Text, username);
            en.Show();
        }

        private void btn_note13_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note13.Text, username);
            en.Show();
        }

        private void btn_note14_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note14.Text, username);
            en.Show();
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            string[] names = new string[15];
            lbl_wellcomeUsername.Text = "Wellcome to NoteBook " + user + '!';
            StreamReader sr = new StreamReader(@"database\users\" + username + ".dat");
            string line = null;
            int k = 0;
            while ((line = sr.ReadLine()) != null)
            {
                names[k] = line;
                k++;
            }

            fillButtons(names);

            sr.Close();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this account?", "Delete", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                DialogResult dr2 = MessageBox.Show("Account will be deleted!\nThis operation cannot be undone!", "Delete", MessageBoxButtons.YesNoCancel);
                if (dr2 == DialogResult.Yes)
                {
                    string str = null;
                    StreamReader sr = new StreamReader(@"database\users\" + username + ".dat");
                    while ((str = sr.ReadLine()) != null) File.Delete(Path.Combine(@"database\notes\" + str + ".dat"));
                    sr.Close();
                    File.Delete(Path.Combine(@"database\users\" + username + ".dat"));
                    sr = new StreamReader(@"database\login.dat");
                    int k = 0;
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        str = line.Substring(0, line.IndexOf('-'));
                        if (str == username) break;
                        k++;
                    }
                    sr.Close();
                    string[] lines = File.ReadAllLines(@"database\login.dat").ToArray();
                    StreamWriter sw = new StreamWriter(@"database\login.dat");
                    line = "";
                    for (int i = 0; i < lines.Length; i++) if (i != k) line += lines[i] + "\n";
                    sw.Write(line);
                    sw.Close();
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                    timer_refresh.Stop();
                }
            }
        }

        private void btn_note15_Click(object sender, EventArgs e)
        {
            Edit_note en = new Edit_note(btn_note15.Text, username);
            en.Show();
        }
    }
}
