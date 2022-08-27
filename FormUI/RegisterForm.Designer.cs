namespace FormUI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.groupBox_register = new System.Windows.Forms.GroupBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_hide_password = new System.Windows.Forms.PictureBox();
            this.button_show_password = new System.Windows.Forms.PictureBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_user_name = new System.Windows.Forms.TextBox();
            this.button_collaps = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.PictureBox();
            this.groupBox_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_hide_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_show_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_collaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_register
            // 
            this.groupBox_register.Controls.Add(this.button_register);
            this.groupBox_register.Controls.Add(this.button_hide_password);
            this.groupBox_register.Controls.Add(this.button_show_password);
            this.groupBox_register.Controls.Add(this.pictureBox_user);
            this.groupBox_register.Controls.Add(this.textBox_password);
            this.groupBox_register.Controls.Add(this.textBox_user_name);
            this.groupBox_register.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox_register.Location = new System.Drawing.Point(12, 83);
            this.groupBox_register.Name = "groupBox_register";
            this.groupBox_register.Size = new System.Drawing.Size(459, 504);
            this.groupBox_register.TabIndex = 5;
            this.groupBox_register.TabStop = false;
            this.groupBox_register.Text = "Kayıt Oluştur";
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.button_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(152)))), ((int)(((byte)(179)))));
            this.button_register.Location = new System.Drawing.Point(81, 323);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(319, 73);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Kayıt Oluştur";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
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
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(30, 177);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(370, 41);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_user_name
            // 
            this.textBox_user_name.Location = new System.Drawing.Point(30, 54);
            this.textBox_user_name.Name = "textBox_user_name";
            this.textBox_user_name.Size = new System.Drawing.Size(370, 41);
            this.textBox_user_name.TabIndex = 0;
            this.textBox_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_collaps
            // 
            this.button_collaps.Image = ((System.Drawing.Image)(resources.GetObject("button_collaps.Image")));
            this.button_collaps.Location = new System.Drawing.Point(359, 12);
            this.button_collaps.Name = "button_collaps";
            this.button_collaps.Size = new System.Drawing.Size(53, 53);
            this.button_collaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_collaps.TabIndex = 4;
            this.button_collaps.TabStop = false;
            this.button_collaps.Click += new System.EventHandler(this.button_collaps_Click);
            // 
            // button_close
            // 
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(418, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(53, 53);
            this.button_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_close.TabIndex = 3;
            this.button_close.TabStop = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(483, 644);
            this.Controls.Add(this.groupBox_register);
            this.Controls.Add(this.button_collaps);
            this.Controls.Add(this.button_close);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox_register.ResumeLayout(false);
            this.groupBox_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_hide_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_show_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_collaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_register;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.PictureBox button_hide_password;
        private System.Windows.Forms.PictureBox button_show_password;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_user_name;
        private System.Windows.Forms.PictureBox button_collaps;
        private System.Windows.Forms.PictureBox button_close;
    }
}