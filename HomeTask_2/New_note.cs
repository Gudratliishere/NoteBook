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
    public partial class New_note : Form
    {
        string username = null;
        public New_note(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void tb_fileName_Enter(object sender, EventArgs e)
        {
            if (tb_fileName.Text == "File name")
            {
                tb_fileName.Text = "";
                tb_fileName.ForeColor = Color.Black;
            }
        }

        private void tb_fileName_Leave(object sender, EventArgs e)
        {
            if (tb_fileName.Text == "")
            {
                tb_fileName.Text = "File name";
                tb_fileName.ForeColor = Color.Gray;
            }
        }

        private void btn_createNote_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"database\users\" + username + ".dat");
            string filename = null;
            bool key = false;
            while ((filename = sr.ReadLine()) != null)
                if (filename == tb_fileName.Text)
                {
                    key = true;
                    break;
                }
            sr.Close();
            if (key) MessageBox.Show("Filename is already exist!", "Error");
            else
            {
                File.AppendAllText(@"database\users\" + username + ".dat", tb_fileName.Text + "\n");
                string path = "database\\notes\\" + tb_fileName.Text + ".dat";
                StreamWriter sw = new StreamWriter(path);
                sw.Write(tb_note.Text);
                sw.Close();
                MessageBox.Show("Note is saved!");
                this.Hide();
            }
        }
    }
}
