namespace HomeTask_2
{
    partial class Sign_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in));
            this.lbl_sign_in = new System.Windows.Forms.Label();
            this.pb_username = new System.Windows.Forms.PictureBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pb_username2 = new System.Windows.Forms.PictureBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pb_passwordConfirm = new System.Windows.Forms.PictureBox();
            this.tb_passwordConfirm = new System.Windows.Forms.TextBox();
            this.lbl_passwordConfirm = new System.Windows.Forms.Label();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.lbl_errorUsername = new System.Windows.Forms.Label();
            this.lbl_errorPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_passwordConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sign_in
            // 
            this.lbl_sign_in.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sign_in.AutoSize = true;
            this.lbl_sign_in.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sign_in.ForeColor = System.Drawing.Color.White;
            this.lbl_sign_in.Location = new System.Drawing.Point(86, 23);
            this.lbl_sign_in.Name = "lbl_sign_in";
            this.lbl_sign_in.Size = new System.Drawing.Size(73, 23);
            this.lbl_sign_in.TabIndex = 4;
            this.lbl_sign_in.Text = "Sign in";
            // 
            // pb_username
            // 
            this.pb_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_username.BackgroundImage")));
            this.pb_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_username.Location = new System.Drawing.Point(8, 78);
            this.pb_username.Name = "pb_username";
            this.pb_username.Size = new System.Drawing.Size(33, 25);
            this.pb_username.TabIndex = 10;
            this.pb_username.TabStop = false;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.tb_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_name.Location = new System.Drawing.Point(42, 78);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(202, 24);
            this.tb_name.TabIndex = 9;
            this.tb_name.Text = "Dunay Gudratli";
            this.tb_name.Enter += new System.EventHandler(this.tb_name_Enter);
            this.tb_name.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(8, 54);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(84, 21);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Full name";
            // 
            // pb_username2
            // 
            this.pb_username2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_username2.BackgroundImage")));
            this.pb_username2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_username2.Location = new System.Drawing.Point(8, 135);
            this.pb_username2.Name = "pb_username2";
            this.pb_username2.Size = new System.Drawing.Size(33, 25);
            this.pb_username2.TabIndex = 13;
            this.pb_username2.TabStop = false;
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.tb_username.ForeColor = System.Drawing.Color.Gray;
            this.tb_username.Location = new System.Drawing.Point(42, 135);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(202, 24);
            this.tb_username.TabIndex = 12;
            this.tb_username.Text = "Kudratli";
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(8, 111);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(88, 21);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "Username";
            // 
            // pb_password
            // 
            this.pb_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_password.BackgroundImage")));
            this.pb_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_password.Location = new System.Drawing.Point(8, 185);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(33, 25);
            this.pb_password.TabIndex = 16;
            this.pb_password.TabStop = false;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(42, 186);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(202, 24);
            this.tb_password.TabIndex = 15;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(8, 161);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(82, 21);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Password";
            // 
            // pb_passwordConfirm
            // 
            this.pb_passwordConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_passwordConfirm.BackgroundImage")));
            this.pb_passwordConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_passwordConfirm.Location = new System.Drawing.Point(8, 240);
            this.pb_passwordConfirm.Name = "pb_passwordConfirm";
            this.pb_passwordConfirm.Size = new System.Drawing.Size(33, 25);
            this.pb_passwordConfirm.TabIndex = 19;
            this.pb_passwordConfirm.TabStop = false;
            // 
            // tb_passwordConfirm
            // 
            this.tb_passwordConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_passwordConfirm.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.tb_passwordConfirm.ForeColor = System.Drawing.Color.Black;
            this.tb_passwordConfirm.Location = new System.Drawing.Point(42, 241);
            this.tb_passwordConfirm.Name = "tb_passwordConfirm";
            this.tb_passwordConfirm.PasswordChar = '*';
            this.tb_passwordConfirm.Size = new System.Drawing.Size(202, 24);
            this.tb_passwordConfirm.TabIndex = 18;
            // 
            // lbl_passwordConfirm
            // 
            this.lbl_passwordConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_passwordConfirm.AutoSize = true;
            this.lbl_passwordConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_passwordConfirm.ForeColor = System.Drawing.Color.White;
            this.lbl_passwordConfirm.Location = new System.Drawing.Point(8, 216);
            this.lbl_passwordConfirm.Name = "lbl_passwordConfirm";
            this.lbl_passwordConfirm.Size = new System.Drawing.Size(149, 21);
            this.lbl_passwordConfirm.TabIndex = 17;
            this.lbl_passwordConfirm.Text = "Confirm password";
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sign_in.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sign_in.BackgroundImage")));
            this.btn_sign_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sign_in.FlatAppearance.BorderSize = 0;
            this.btn_sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_in.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_in.Location = new System.Drawing.Point(115, 271);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(129, 37);
            this.btn_sign_in.TabIndex = 20;
            this.btn_sign_in.UseVisualStyleBackColor = true;
            this.btn_sign_in.Click += new System.EventHandler(this.btn_sign_in_Click);
            // 
            // lbl_errorUsername
            // 
            this.lbl_errorUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_errorUsername.AutoSize = true;
            this.lbl_errorUsername.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_errorUsername.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_errorUsername.Location = new System.Drawing.Point(102, 116);
            this.lbl_errorUsername.Name = "lbl_errorUsername";
            this.lbl_errorUsername.Size = new System.Drawing.Size(145, 16);
            this.lbl_errorUsername.TabIndex = 21;
            this.lbl_errorUsername.Text = "Username already exist!";
            this.lbl_errorUsername.Visible = false;
            // 
            // lbl_errorPassword
            // 
            this.lbl_errorPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_errorPassword.AutoSize = true;
            this.lbl_errorPassword.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_errorPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_errorPassword.Location = new System.Drawing.Point(112, 167);
            this.lbl_errorPassword.Name = "lbl_errorPassword";
            this.lbl_errorPassword.Size = new System.Drawing.Size(136, 16);
            this.lbl_errorPassword.TabIndex = 22;
            this.lbl_errorPassword.Text = "Passwords is different!";
            this.lbl_errorPassword.Visible = false;
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(256, 323);
            this.Controls.Add(this.lbl_errorPassword);
            this.Controls.Add(this.lbl_errorUsername);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.pb_passwordConfirm);
            this.Controls.Add(this.tb_passwordConfirm);
            this.Controls.Add(this.lbl_passwordConfirm);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.pb_username2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pb_username);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_sign_in);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)(this.pb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_username2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_passwordConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sign_in;
        private System.Windows.Forms.PictureBox pb_username;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pb_username2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.PictureBox pb_passwordConfirm;
        private System.Windows.Forms.TextBox tb_passwordConfirm;
        private System.Windows.Forms.Label lbl_passwordConfirm;
        private System.Windows.Forms.Button btn_sign_in;
        private System.Windows.Forms.Label lbl_errorUsername;
        private System.Windows.Forms.Label lbl_errorPassword;
    }
}