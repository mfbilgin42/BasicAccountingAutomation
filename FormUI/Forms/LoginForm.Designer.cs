namespace FormUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_close = new System.Windows.Forms.PictureBox();
            this.button_collaps = new System.Windows.Forms.PictureBox();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_hide_password = new System.Windows.Forms.PictureBox();
            this.button_show_password = new System.Windows.Forms.PictureBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_user_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_collaps)).BeginInit();
            this.groupBox_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_hide_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_show_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(418, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(53, 53);
            this.button_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_close.TabIndex = 0;
            this.button_close.TabStop = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_collaps
            // 
            this.button_collaps.Image = ((System.Drawing.Image)(resources.GetObject("button_collaps.Image")));
            this.button_collaps.Location = new System.Drawing.Point(359, 12);
            this.button_collaps.Name = "button_collaps";
            this.button_collaps.Size = new System.Drawing.Size(53, 53);
            this.button_collaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_collaps.TabIndex = 1;
            this.button_collaps.TabStop = false;
            this.button_collaps.Tag = "Collapse";
            this.button_collaps.Click += new System.EventHandler(this.button_collaps_Click);
            // 
            // groupBox_login
            // 
            this.groupBox_login.Controls.Add(this.button_login);
            this.groupBox_login.Controls.Add(this.button_hide_password);
            this.groupBox_login.Controls.Add(this.button_show_password);
            this.groupBox_login.Controls.Add(this.pictureBox_user);
            this.groupBox_login.Controls.Add(this.textBox_password);
            this.groupBox_login.Controls.Add(this.textBox_user_name);
            this.groupBox_login.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox_login.Location = new System.Drawing.Point(12, 83);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(459, 504);
            this.groupBox_login.TabIndex = 2;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Giriş Yap";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.button_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(152)))), ((int)(((byte)(179)))));
            this.button_login.Location = new System.Drawing.Point(81, 323);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(319, 73);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Giriş Yap";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_hide_password
            // 
            this.button_hide_password.Image = ((System.Drawing.Image)(resources.GetObject("button_hide_password.Image")));
            this.button_hide_password.Location = new System.Drawing.Point(406, 177);
            this.button_hide_password.Name = "button_hide_password";
            this.button_hide_password.Size = new System.Drawing.Size(47, 41);
            this.button_hide_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_hide_password.TabIndex = 4;
            this.button_hide_password.TabStop = false;
            this.button_hide_password.Click += new System.EventHandler(this.button_hide_password_Click);
            // 
            // button_show_password
            // 
            this.button_show_password.Image = ((System.Drawing.Image)(resources.GetObject("button_show_password.Image")));
            this.button_show_password.Location = new System.Drawing.Point(406, 177);
            this.button_show_password.Name = "button_show_password";
            this.button_show_password.Size = new System.Drawing.Size(47, 41);
            this.button_show_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_show_password.TabIndex = 3;
            this.button_show_password.TabStop = false;
            this.button_show_password.Click += new System.EventHandler(this.button_show_password_Click);
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_user.Image")));
            this.pictureBox_user.Location = new System.Drawing.Point(406, 54);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(47, 41);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_user.TabIndex = 2;
            this.pictureBox_user.TabStop = false;
            this.pictureBox_user.Click += new System.EventHandler(this.pictureBox_user_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(30, 177);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(370, 41);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown_1);
            // 
            // textBox_user_name
            // 
            this.textBox_user_name.Location = new System.Drawing.Point(30, 54);
            this.textBox_user_name.Name = "textBox_user_name";
            this.textBox_user_name.Size = new System.Drawing.Size(370, 41);
            this.textBox_user_name.TabIndex = 0;
            this.textBox_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_user_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_user_name_KeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(483, 644);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.button_collaps);
            this.Controls.Add(this.button_close);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_collaps)).EndInit();
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_hide_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_show_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox button_close;
        private System.Windows.Forms.PictureBox button_collaps;
        private System.Windows.Forms.GroupBox groupBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_user_name;
        private System.Windows.Forms.PictureBox button_hide_password;
        private System.Windows.Forms.PictureBox button_show_password;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Button button_login;
    }
}
