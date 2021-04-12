namespace HomeTask_2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_wellcomeUsername = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_createNote = new System.Windows.Forms.Button();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.btn_note15 = new System.Windows.Forms.Button();
            this.btn_note14 = new System.Windows.Forms.Button();
            this.btn_note13 = new System.Windows.Forms.Button();
            this.btn_note12 = new System.Windows.Forms.Button();
            this.btn_note11 = new System.Windows.Forms.Button();
            this.btn_note10 = new System.Windows.Forms.Button();
            this.btn_note9 = new System.Windows.Forms.Button();
            this.btn_note8 = new System.Windows.Forms.Button();
            this.btn_note7 = new System.Windows.Forms.Button();
            this.btn_note6 = new System.Windows.Forms.Button();
            this.btn_note5 = new System.Windows.Forms.Button();
            this.btn_note4 = new System.Windows.Forms.Button();
            this.btn_note3 = new System.Windows.Forms.Button();
            this.btn_note2 = new System.Windows.Forms.Button();
            this.btn_note1 = new System.Windows.Forms.Button();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.tlp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_wellcomeUsername
            // 
            this.lbl_wellcomeUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_wellcomeUsername.AutoSize = true;
            this.lbl_wellcomeUsername.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_wellcomeUsername.ForeColor = System.Drawing.Color.Black;
            this.lbl_wellcomeUsername.Location = new System.Drawing.Point(22, 9);
            this.lbl_wellcomeUsername.Name = "lbl_wellcomeUsername";
            this.lbl_wellcomeUsername.Size = new System.Drawing.Size(260, 23);
            this.lbl_wellcomeUsername.TabIndex = 5;
            this.lbl_wellcomeUsername.Text = "Wellcome to NoteBook user!";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_top.Controls.Add(this.btn_createNote);
            this.pnl_top.Controls.Add(this.lbl_wellcomeUsername);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(721, 45);
            this.pnl_top.TabIndex = 6;
            // 
            // btn_createNote
            // 
            this.btn_createNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_createNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createNote.FlatAppearance.BorderSize = 0;
            this.btn_createNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createNote.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_createNote.ForeColor = System.Drawing.Color.Black;
            this.btn_createNote.Location = new System.Drawing.Point(571, 6);
            this.btn_createNote.Name = "btn_createNote";
            this.btn_createNote.Size = new System.Drawing.Size(138, 28);
            this.btn_createNote.TabIndex = 8;
            this.btn_createNote.Text = "Create new";
            this.btn_createNote.UseVisualStyleBackColor = true;
            this.btn_createNote.Click += new System.EventHandler(this.btn_createNote_Click);
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_bottom.Controls.Add(this.btn_delete);
            this.pnl_bottom.Controls.Add(this.btn_logOut);
            this.pnl_bottom.Controls.Add(this.lbl_copyright);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 366);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(721, 35);
            this.pnl_bottom.TabIndex = 7;
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_logOut.ForeColor = System.Drawing.Color.Black;
            this.btn_logOut.Location = new System.Drawing.Point(0, 3);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(101, 28);
            this.btn_logOut.TabIndex = 9;
            this.btn_logOut.Text = "Log out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_copyright.ForeColor = System.Drawing.Color.Black;
            this.lbl_copyright.Location = new System.Drawing.Point(491, 10);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(218, 16);
            this.lbl_copyright.TabIndex = 6;
            this.lbl_copyright.Text = "All rights reserved! ⓒ Dunay Gudratli";
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 5;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_main.Controls.Add(this.btn_note15, 4, 2);
            this.tlp_main.Controls.Add(this.btn_note14, 3, 2);
            this.tlp_main.Controls.Add(this.btn_note13, 2, 2);
            this.tlp_main.Controls.Add(this.btn_note12, 1, 2);
            this.tlp_main.Controls.Add(this.btn_note11, 0, 2);
            this.tlp_main.Controls.Add(this.btn_note10, 4, 1);
            this.tlp_main.Controls.Add(this.btn_note9, 3, 1);
            this.tlp_main.Controls.Add(this.btn_note8, 2, 1);
            this.tlp_main.Controls.Add(this.btn_note7, 1, 1);
            this.tlp_main.Controls.Add(this.btn_note6, 0, 1);
            this.tlp_main.Controls.Add(this.btn_note5, 4, 0);
            this.tlp_main.Controls.Add(this.btn_note4, 3, 0);
            this.tlp_main.Controls.Add(this.btn_note3, 2, 0);
            this.tlp_main.Controls.Add(this.btn_note2, 1, 0);
            this.tlp_main.Controls.Add(this.btn_note1, 0, 0);
            this.tlp_main.Location = new System.Drawing.Point(12, 51);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_main.Size = new System.Drawing.Size(697, 309);
            this.tlp_main.TabIndex = 8;
            // 
            // btn_note15
            // 
            this.btn_note15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note15.FlatAppearance.BorderSize = 0;
            this.btn_note15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note15.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note15.ForeColor = System.Drawing.Color.Black;
            this.btn_note15.Location = new System.Drawing.Point(561, 209);
            this.btn_note15.Name = "btn_note15";
            this.btn_note15.Size = new System.Drawing.Size(133, 96);
            this.btn_note15.TabIndex = 23;
            this.btn_note15.Text = "Note name";
            this.btn_note15.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note15.UseVisualStyleBackColor = true;
            this.btn_note15.Visible = false;
            this.btn_note15.Click += new System.EventHandler(this.btn_note15_Click);
            // 
            // btn_note14
            // 
            this.btn_note14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note14.FlatAppearance.BorderSize = 0;
            this.btn_note14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note14.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note14.ForeColor = System.Drawing.Color.Black;
            this.btn_note14.Location = new System.Drawing.Point(420, 209);
            this.btn_note14.Name = "btn_note14";
            this.btn_note14.Size = new System.Drawing.Size(133, 96);
            this.btn_note14.TabIndex = 22;
            this.btn_note14.Text = "Note name";
            this.btn_note14.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note14.UseVisualStyleBackColor = true;
            this.btn_note14.Visible = false;
            this.btn_note14.Click += new System.EventHandler(this.btn_note14_Click);
            // 
            // btn_note13
            // 
            this.btn_note13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note13.FlatAppearance.BorderSize = 0;
            this.btn_note13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note13.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note13.ForeColor = System.Drawing.Color.Black;
            this.btn_note13.Location = new System.Drawing.Point(281, 209);
            this.btn_note13.Name = "btn_note13";
            this.btn_note13.Size = new System.Drawing.Size(133, 96);
            this.btn_note13.TabIndex = 21;
            this.btn_note13.Text = "Note name";
            this.btn_note13.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note13.UseVisualStyleBackColor = true;
            this.btn_note13.Visible = false;
            this.btn_note13.Click += new System.EventHandler(this.btn_note13_Click);
            // 
            // btn_note12
            // 
            this.btn_note12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note12.FlatAppearance.BorderSize = 0;
            this.btn_note12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note12.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note12.ForeColor = System.Drawing.Color.Black;
            this.btn_note12.Location = new System.Drawing.Point(142, 209);
            this.btn_note12.Name = "btn_note12";
            this.btn_note12.Size = new System.Drawing.Size(133, 96);
            this.btn_note12.TabIndex = 20;
            this.btn_note12.Text = "Note name";
            this.btn_note12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note12.UseVisualStyleBackColor = true;
            this.btn_note12.Visible = false;
            this.btn_note12.Click += new System.EventHandler(this.btn_note12_Click);
            // 
            // btn_note11
            // 
            this.btn_note11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note11.FlatAppearance.BorderSize = 0;
            this.btn_note11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note11.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note11.ForeColor = System.Drawing.Color.Black;
            this.btn_note11.Location = new System.Drawing.Point(3, 209);
            this.btn_note11.Name = "btn_note11";
            this.btn_note11.Size = new System.Drawing.Size(133, 96);
            this.btn_note11.TabIndex = 19;
            this.btn_note11.Text = "Note name";
            this.btn_note11.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note11.UseVisualStyleBackColor = true;
            this.btn_note11.Visible = false;
            this.btn_note11.Click += new System.EventHandler(this.btn_note11_Click);
            // 
            // btn_note10
            // 
            this.btn_note10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note10.FlatAppearance.BorderSize = 0;
            this.btn_note10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note10.ForeColor = System.Drawing.Color.Black;
            this.btn_note10.Location = new System.Drawing.Point(561, 106);
            this.btn_note10.Name = "btn_note10";
            this.btn_note10.Size = new System.Drawing.Size(133, 96);
            this.btn_note10.TabIndex = 18;
            this.btn_note10.Text = "Note name";
            this.btn_note10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note10.UseVisualStyleBackColor = true;
            this.btn_note10.Visible = false;
            this.btn_note10.Click += new System.EventHandler(this.btn_note10_Click);
            // 
            // btn_note9
            // 
            this.btn_note9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note9.FlatAppearance.BorderSize = 0;
            this.btn_note9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note9.ForeColor = System.Drawing.Color.Black;
            this.btn_note9.Location = new System.Drawing.Point(420, 106);
            this.btn_note9.Name = "btn_note9";
            this.btn_note9.Size = new System.Drawing.Size(133, 96);
            this.btn_note9.TabIndex = 17;
            this.btn_note9.Text = "Note name";
            this.btn_note9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note9.UseVisualStyleBackColor = true;
            this.btn_note9.Visible = false;
            this.btn_note9.Click += new System.EventHandler(this.btn_note9_Click);
            // 
            // btn_note8
            // 
            this.btn_note8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note8.FlatAppearance.BorderSize = 0;
            this.btn_note8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note8.ForeColor = System.Drawing.Color.Black;
            this.btn_note8.Location = new System.Drawing.Point(281, 106);
            this.btn_note8.Name = "btn_note8";
            this.btn_note8.Size = new System.Drawing.Size(133, 96);
            this.btn_note8.TabIndex = 16;
            this.btn_note8.Text = "Note name";
            this.btn_note8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note8.UseVisualStyleBackColor = true;
            this.btn_note8.Visible = false;
            this.btn_note8.Click += new System.EventHandler(this.btn_note8_Click);
            // 
            // btn_note7
            // 
            this.btn_note7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note7.FlatAppearance.BorderSize = 0;
            this.btn_note7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note7.ForeColor = System.Drawing.Color.Black;
            this.btn_note7.Location = new System.Drawing.Point(142, 106);
            this.btn_note7.Name = "btn_note7";
            this.btn_note7.Size = new System.Drawing.Size(133, 96);
            this.btn_note7.TabIndex = 15;
            this.btn_note7.Text = "Note name";
            this.btn_note7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note7.UseVisualStyleBackColor = true;
            this.btn_note7.Visible = false;
            this.btn_note7.Click += new System.EventHandler(this.btn_note7_Click);
            // 
            // btn_note6
            // 
            this.btn_note6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note6.FlatAppearance.BorderSize = 0;
            this.btn_note6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note6.ForeColor = System.Drawing.Color.Black;
            this.btn_note6.Location = new System.Drawing.Point(3, 106);
            this.btn_note6.Name = "btn_note6";
            this.btn_note6.Size = new System.Drawing.Size(133, 96);
            this.btn_note6.TabIndex = 14;
            this.btn_note6.Text = "Note name";
            this.btn_note6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note6.UseVisualStyleBackColor = true;
            this.btn_note6.Visible = false;
            this.btn_note6.Click += new System.EventHandler(this.btn_note6_Click);
            // 
            // btn_note5
            // 
            this.btn_note5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note5.FlatAppearance.BorderSize = 0;
            this.btn_note5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note5.ForeColor = System.Drawing.Color.Black;
            this.btn_note5.Location = new System.Drawing.Point(561, 3);
            this.btn_note5.Name = "btn_note5";
            this.btn_note5.Size = new System.Drawing.Size(133, 96);
            this.btn_note5.TabIndex = 13;
            this.btn_note5.Text = "Note name";
            this.btn_note5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note5.UseVisualStyleBackColor = true;
            this.btn_note5.Visible = false;
            this.btn_note5.Click += new System.EventHandler(this.btn_note5_Click);
            // 
            // btn_note4
            // 
            this.btn_note4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note4.FlatAppearance.BorderSize = 0;
            this.btn_note4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note4.ForeColor = System.Drawing.Color.Black;
            this.btn_note4.Location = new System.Drawing.Point(420, 3);
            this.btn_note4.Name = "btn_note4";
            this.btn_note4.Size = new System.Drawing.Size(133, 96);
            this.btn_note4.TabIndex = 12;
            this.btn_note4.Text = "Note name";
            this.btn_note4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note4.UseVisualStyleBackColor = true;
            this.btn_note4.Visible = false;
            this.btn_note4.Click += new System.EventHandler(this.btn_note4_Click);
            // 
            // btn_note3
            // 
            this.btn_note3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note3.FlatAppearance.BorderSize = 0;
            this.btn_note3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note3.ForeColor = System.Drawing.Color.Black;
            this.btn_note3.Location = new System.Drawing.Point(281, 3);
            this.btn_note3.Name = "btn_note3";
            this.btn_note3.Size = new System.Drawing.Size(133, 96);
            this.btn_note3.TabIndex = 11;
            this.btn_note3.Text = "Note name";
            this.btn_note3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note3.UseVisualStyleBackColor = true;
            this.btn_note3.Visible = false;
            this.btn_note3.Click += new System.EventHandler(this.btn_note3_Click);
            // 
            // btn_note2
            // 
            this.btn_note2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note2.FlatAppearance.BorderSize = 0;
            this.btn_note2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note2.ForeColor = System.Drawing.Color.Black;
            this.btn_note2.Location = new System.Drawing.Point(142, 3);
            this.btn_note2.Name = "btn_note2";
            this.btn_note2.Size = new System.Drawing.Size(133, 96);
            this.btn_note2.TabIndex = 10;
            this.btn_note2.Text = "Note name";
            this.btn_note2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note2.UseVisualStyleBackColor = true;
            this.btn_note2.Visible = false;
            this.btn_note2.Click += new System.EventHandler(this.btn_note2_Click);
            // 
            // btn_note1
            // 
            this.btn_note1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_note1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_note1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_note1.FlatAppearance.BorderSize = 0;
            this.btn_note1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_note1.ForeColor = System.Drawing.Color.Black;
            this.btn_note1.Location = new System.Drawing.Point(3, 3);
            this.btn_note1.Name = "btn_note1";
            this.btn_note1.Size = new System.Drawing.Size(133, 96);
            this.btn_note1.TabIndex = 9;
            this.btn_note1.Text = "Note name";
            this.btn_note1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_note1.UseVisualStyleBackColor = true;
            this.btn_note1.Visible = false;
            this.btn_note1.Click += new System.EventHandler(this.btn_note1_Click);
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(96, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(148, 28);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete account";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(721, 401);
            this.Controls.Add(this.tlp_main);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.tlp_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_wellcomeUsername;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.Button btn_createNote;
        private System.Windows.Forms.Button btn_note15;
        private System.Windows.Forms.Button btn_note14;
        private System.Windows.Forms.Button btn_note13;
        private System.Windows.Forms.Button btn_note12;
        private System.Windows.Forms.Button btn_note11;
        private System.Windows.Forms.Button btn_note10;
        private System.Windows.Forms.Button btn_note9;
        private System.Windows.Forms.Button btn_note8;
        private System.Windows.Forms.Button btn_note7;
        private System.Windows.Forms.Button btn_note6;
        private System.Windows.Forms.Button btn_note5;
        private System.Windows.Forms.Button btn_note4;
        private System.Windows.Forms.Button btn_note3;
        private System.Windows.Forms.Button btn_note2;
        private System.Windows.Forms.Button btn_note1;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_delete;
    }
}