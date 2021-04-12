namespace HomeTask_2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_wellcome = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.lbl_bottomText = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.pb_username = new System.Windows.Forms.PictureBox();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            this.pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(12, 57);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(88, 21);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.tb_username.ForeColor = System.Drawing.Color.Gray;
            this.tb_username.Location = new System.Drawing.Point(46, 81);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(198, 24);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "Kudratli";
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // lbl_wellcome
            // 
            this.lbl_wellcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_wellcome.AutoSize = true;
            this.lbl_wellcome.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_wellcome.ForeColor = System.Drawing.Color.White;
            this.lbl_wellcome.Location = new System.Drawing.Point(24, 18);
            this.lbl_wellcome.Name = "lbl_wellcome";
            this.lbl_wellcome.Size = new System.Drawing.Size(210, 23);
            this.lbl_wellcome.TabIndex = 0;
            this.lbl_wellcome.Text = "Wellcome to NoteBook";
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(46, 143);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(198, 24);
            this.tb_password.TabIndex = 5;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(12, 118);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(82, 21);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.LightBlue;
            this.pnl_bottom.Controls.Add(this.btn_createAccount);
            this.pnl_bottom.Controls.Add(this.lbl_bottomText);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 234);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(260, 34);
            this.pnl_bottom.TabIndex = 6;
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createAccount.FlatAppearance.BorderSize = 0;
            this.btn_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.btn_createAccount.ForeColor = System.Drawing.Color.Blue;
            this.btn_createAccount.Location = new System.Drawing.Point(164, 3);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(80, 28);
            this.btn_createAccount.TabIndex = 7;
            this.btn_createAccount.Text = "Create new";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // lbl_bottomText
            // 
            this.lbl_bottomText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_bottomText.AutoSize = true;
            this.lbl_bottomText.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bottomText.ForeColor = System.Drawing.Color.Black;
            this.lbl_bottomText.Location = new System.Drawing.Point(13, 9);
            this.lbl_bottomText.Name = "lbl_bottomText";
            this.lbl_bottomText.Size = new System.Drawing.Size(155, 16);
            this.lbl_bottomText.TabIndex = 7;
            this.lbl_bottomText.Text = "Don\'t you have an account?";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(155, 173);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 37);
            this.btn_login.TabIndex = 2;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pb_username
            // 
            this.pb_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_username.BackgroundImage")));
            this.pb_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_username.Location = new System.Drawing.Point(12, 81);
            this.pb_username.Name = "pb_username";
            this.pb_username.Size = new System.Drawing.Size(33, 25);
            this.pb_username.TabIndex = 7;
            this.pb_username.TabStop = false;
            // 
            // pb_password
            // 
            this.pb_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_password.BackgroundImage")));
            this.pb_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_password.Location = new System.Drawing.Point(12, 142);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(33, 25);
            this.pb_password.TabIndex = 8;
            this.pb_password.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(24, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_errorMessage.AutoSize = true;
            this.lbl_errorMessage.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_errorMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_errorMessage.Location = new System.Drawing.Point(30, 213);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(189, 16);
            this.lbl_errorMessage.TabIndex = 10;
            this.lbl_errorMessage.Text = "Username or password is wrong!";
            this.lbl_errorMessage.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(260, 268);
            this.Controls.Add(this.lbl_errorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.pb_username);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_wellcome);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_wellcome;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.Label lbl_bottomText;
        private System.Windows.Forms.PictureBox pb_username;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_errorMessage;
    }
}

