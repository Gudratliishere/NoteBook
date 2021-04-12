namespace HomeTask_2
{
    partial class New_note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_note));
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.btn_createNote = new System.Windows.Forms.Button();
            this.pnl_bottom.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_bottom.Controls.Add(this.lbl_copyright);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 367);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(719, 35);
            this.pnl_bottom.TabIndex = 10;
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_copyright.ForeColor = System.Drawing.Color.Black;
            this.lbl_copyright.Location = new System.Drawing.Point(489, 10);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(218, 16);
            this.lbl_copyright.TabIndex = 6;
            this.lbl_copyright.Text = "All rights reserved! ⓒ Dunay Gudratli";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_top.Controls.Add(this.tb_fileName);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(719, 45);
            this.pnl_top.TabIndex = 9;
            // 
            // tb_fileName
            // 
            this.tb_fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_fileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.tb_fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fileName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.tb_fileName.ForeColor = System.Drawing.Color.Gray;
            this.tb_fileName.Location = new System.Drawing.Point(12, 12);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(331, 24);
            this.tb_fileName.TabIndex = 10;
            this.tb_fileName.Text = "File name";
            this.tb_fileName.Enter += new System.EventHandler(this.tb_fileName_Enter);
            this.tb_fileName.Leave += new System.EventHandler(this.tb_fileName_Leave);
            // 
            // tb_note
            // 
            this.tb_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_note.BackColor = System.Drawing.Color.White;
            this.tb_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_note.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_note.ForeColor = System.Drawing.Color.Black;
            this.tb_note.Location = new System.Drawing.Point(12, 51);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_note.Size = new System.Drawing.Size(695, 263);
            this.tb_note.TabIndex = 11;
            // 
            // btn_createNote
            // 
            this.btn_createNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_createNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createNote.FlatAppearance.BorderSize = 0;
            this.btn_createNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createNote.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_createNote.ForeColor = System.Drawing.Color.Black;
            this.btn_createNote.Location = new System.Drawing.Point(569, 320);
            this.btn_createNote.Name = "btn_createNote";
            this.btn_createNote.Size = new System.Drawing.Size(138, 28);
            this.btn_createNote.TabIndex = 12;
            this.btn_createNote.Text = "Save";
            this.btn_createNote.UseVisualStyleBackColor = true;
            this.btn_createNote.Click += new System.EventHandler(this.btn_createNote_Click);
            // 
            // New_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(719, 402);
            this.Controls.Add(this.btn_createNote);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_note";
            this.Text = "New note";
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Button btn_createNote;
    }
}