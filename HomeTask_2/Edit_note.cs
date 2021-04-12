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
    public partial class Edit_note : Form
    {
        string filename = null, username = null;
        public Edit_note(string filename, string username)
        {
            this.filename = filename;
            this.username = username;
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            tb_note.ReadOnly = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            tb_note.ReadOnly = true;
            StreamWriter sw = new StreamWriter(@"database\notes\" + filename + ".dat");
            sw.Write(tb_note.Text);
            sw.Close();
            MessageBox.Show("Note successfully saved!", "Done");
        }

        private void Edit_note_Load(object sender, EventArgs e)
        {
            lbl_fileName.Text = filename;
            StreamReader sr = new StreamReader(@"database\notes\" + filename + ".dat");
            tb_note.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this note?", "Delete", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                File.Delete(Path.Combine(@"database\notes\", filename + ".dat"));
                StreamReader sr = new StreamReader(@"database\users\" + username + ".dat");
                String str = null;
                int k = 0;
                while ((str = sr.ReadLine()) != null)
                {
                    if (filename == str) break;
                    k++;
                }
                sr.Close();
                string[] linesList = File.ReadAllLines(@"database\users\" + username + ".dat").ToArray();
                string file = "";
                for (int i = 0; i < linesList.Length; i++) if (i != k) file += linesList[i] + "\n";
                StreamWriter sw = new StreamWriter(@"database\users\" + username + ".dat");
                sw.Write(file);
                sw.Close();
                this.Hide();
            }
        }
    }
}
