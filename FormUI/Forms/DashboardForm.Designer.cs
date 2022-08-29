namespace FormUI.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_side = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_shipments = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.panel_app_title = new System.Windows.Forms.Panel();
            this.button_menu = new System.Windows.Forms.Button();
            this.label_app_title_2 = new System.Windows.Forms.Label();
            this.label_app_title = new System.Windows.Forms.Label();
            this.pictureBox_app_image = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_props = new System.Windows.Forms.Panel();
            this.button_product_delete = new System.Windows.Forms.PictureBox();
            this.product_update = new System.Windows.Forms.PictureBox();
            this.button_product_add = new System.Windows.Forms.PictureBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.label_years = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.panel_left.SuspendLayout();
            this.panel_app_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_app_image)).BeginInit();
            this.panel_props.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_product_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_product_add)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.panel_left.Controls.Add(this.panel_side);
            this.panel_left.Controls.Add(this.button_settings);
            this.panel_left.Controls.Add(this.button_customers);
            this.panel_left.Controls.Add(this.button_shipments);
            this.panel_left.Controls.Add(this.button_orders);
            this.panel_left.Controls.Add(this.button_products);
            this.panel_left.Controls.Add(this.panel_app_title);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(215, 720);
            this.panel_left.TabIndex = 0;
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.White;
            this.panel_side.Location = new System.Drawing.Point(0, 140);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(7, 116);
            this.panel_side.TabIndex = 2;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Image = ((System.Drawing.Image)(resources.GetObject("button_settings.Image")));
            this.button_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_settings.Location = new System.Drawing.Point(9, 628);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(203, 89);
            this.button_settings.TabIndex = 1;
            this.button_settings.Text = "    Ayarlar";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_customers
            // 
            this.button_customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.button_customers.FlatAppearance.BorderSize = 0;
            this.button_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers.ForeColor = System.Drawing.Color.White;
            this.button_customers.Image = ((System.Drawing.Image)(resources.GetObject("button_customers.Image")));
            this.button_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_customers.Location = new System.Drawing.Point(9, 506);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(203, 116);
            this.button_customers.TabIndex = 1;
            this.button_customers.Text = "    Müşteriler";
            this.button_customers.UseVisualStyleBackColor = false;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // button_shipments
            // 
            this.button_shipments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.button_shipments.FlatAppearance.BorderSize = 0;
            this.button_shipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shipments.ForeColor = System.Drawing.Color.White;
            this.button_shipments.Image = ((System.Drawing.Image)(resources.GetObject("button_shipments.Image")));
            this.button_shipments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_shipments.Location = new System.Drawing.Point(9, 384);
            this.button_shipments.Name = "button_shipments";
            this.button_shipments.Size = new System.Drawing.Size(203, 116);
            this.button_shipments.TabIndex = 1;
            this.button_shipments.Text = "    Sevkiyatlar";
            this.button_shipments.UseVisualStyleBackColor = false;
            this.button_shipments.Click += new System.EventHandler(this.button_shipments_Click);
            // 
            // button_orders
            // 
            this.button_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.button_orders.FlatAppearance.BorderSize = 0;
            this.button_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_orders.ForeColor = System.Drawing.Color.White;
            this.button_orders.Image = ((System.Drawing.Image)(resources.GetObject("button_orders.Image")));
            this.button_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_orders.Location = new System.Drawing.Point(9, 262);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(203, 116);
            this.button_orders.TabIndex = 1;
            this.button_orders.Text = "    Siparişler";
            this.button_orders.UseVisualStyleBackColor = false;
            this.button_orders.Click += new System.EventHandler(this.button_orders_Click);
            // 
            // button_products
            // 
            this.button_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.button_products.FlatAppearance.BorderSize = 0;
            this.button_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_products.ForeColor = System.Drawing.Color.White;
            this.button_products.Image = ((System.Drawing.Image)(resources.GetObject("button_products.Image")));
            this.button_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_products.Location = new System.Drawing.Point(9, 140);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(203, 116);
            this.button_products.TabIndex = 1;
            this.button_products.Text = "    Ürünler";
            this.button_products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_products.UseVisualStyleBackColor = false;
            this.button_products.Click += new System.EventHandler(this.button_products_Click);
            // 
            // panel_app_title
            // 
            this.panel_app_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.panel_app_title.Controls.Add(this.button_menu);
            this.panel_app_title.Controls.Add(this.label_app_title_2);
            this.panel_app_title.Controls.Add(this.label_app_title);
            this.panel_app_title.Controls.Add(this.pictureBox_app_image);
            this.panel_app_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_app_title.Location = new System.Drawing.Point(0, 0);
            this.panel_app_title.Name = "panel_app_title";
            this.panel_app_title.Size = new System.Drawing.Size(215, 140);
            this.panel_app_title.TabIndex = 0;
            // 
            // button_menu
            // 
            this.button_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.ForeColor = System.Drawing.Color.White;
            this.button_menu.Image = ((System.Drawing.Image)(resources.GetObject("button_menu.Image")));
            this.button_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu.Location = new System.Drawing.Point(169, 3);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(42, 41);
            this.button_menu.TabIndex = 1;
            this.button_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // label_app_title_2
            // 
            this.label_app_title_2.AutoSize = true;
            this.label_app_title_2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_app_title_2.ForeColor = System.Drawing.Color.White;
            this.label_app_title_2.Location = new System.Drawing.Point(52, 110);
            this.label_app_title_2.Name = "label_app_title_2";
            this.label_app_title_2.Size = new System.Drawing.Size(112, 22);
            this.label_app_title_2.TabIndex = 1;
            this.label_app_title_2.Text = "Automation";
            // 
            // label_app_title
            // 
            this.label_app_title.AutoSize = true;
            this.label_app_title.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_app_title.ForeColor = System.Drawing.Color.White;
            this.label_app_title.Location = new System.Drawing.Point(30, 88);
            this.label_app_title.Name = "label_app_title";
            this.label_app_title.Size = new System.Drawing.Size(164, 22);
            this.label_app_title.TabIndex = 1;
            this.label_app_title.Text = "Basic Accounting";
            // 
            // pictureBox_app_image
            // 
            this.pictureBox_app_image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_app_image.Image")));
            this.pictureBox_app_image.Location = new System.Drawing.Point(71, 12);
            this.pictureBox_app_image.Name = "pictureBox_app_image";
            this.pictureBox_app_image.Size = new System.Drawing.Size(76, 73);
            this.pictureBox_app_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_app_image.TabIndex = 0;
            this.pictureBox_app_image.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_close.Location = new System.Drawing.Point(935, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(42, 41);
            this.button_close.TabIndex = 1;
            this.button_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_props
            // 
            this.panel_props.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.panel_props.Controls.Add(this.button_product_delete);
            this.panel_props.Controls.Add(this.product_update);
            this.panel_props.Controls.Add(this.button_product_add);
            this.panel_props.Controls.Add(this.comboBox_year);
            this.panel_props.Controls.Add(this.label_years);
            this.panel_props.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_props.Location = new System.Drawing.Point(215, 50);
            this.panel_props.Name = "panel_props";
            this.panel_props.Size = new System.Drawing.Size(985, 90);
            this.panel_props.TabIndex = 1;
            // 
            // button_product_delete
            // 
            this.button_product_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_product_delete.Image")));
            this.button_product_delete.Location = new System.Drawing.Point(419, 15);
            this.button_product_delete.Name = "button_product_delete";
            this.button_product_delete.Size = new System.Drawing.Size(49, 54);
            this.button_product_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_product_delete.TabIndex = 4;
            this.button_product_delete.TabStop = false;
            // 
            // product_update
            // 
            this.product_update.Image = ((System.Drawing.Image)(resources.GetObject("product_update.Image")));
            this.product_update.Location = new System.Drawing.Point(525, 15);
            this.product_update.Name = "product_update";
            this.product_update.Size = new System.Drawing.Size(49, 54);
            this.product_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_update.TabIndex = 4;
            this.product_update.TabStop = false;
            // 
            // button_product_add
            // 
            this.button_product_add.Image = ((System.Drawing.Image)(resources.GetObject("button_product_add.Image")));
            this.button_product_add.Location = new System.Drawing.Point(319, 15);
            this.button_product_add.Name = "button_product_add";
            this.button_product_add.Size = new System.Drawing.Size(49, 54);
            this.button_product_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_product_add.TabIndex = 4;
            this.button_product_add.TabStop = false;
            // 
            // comboBox_year
            // 
            this.comboBox_year.BackColor = System.Drawing.Color.White;
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(80, 25);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(206, 35);
            this.comboBox_year.TabIndex = 3;
            // 
            // label_years
            // 
            this.label_years.AutoSize = true;
            this.label_years.ForeColor = System.Drawing.Color.White;
            this.label_years.Location = new System.Drawing.Point(27, 29);
            this.label_years.Name = "label_years";
            this.label_years.Size = new System.Drawing.Size(56, 27);
            this.label_years.TabIndex = 2;
            this.label_years.Text = "Yıl : ";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.White;
            this.panel_top.Controls.Add(this.button_close);
            this.panel_top.Controls.Add(this.label_time);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(215, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(985, 50);
            this.panel_top.TabIndex = 1;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.label_time.Location = new System.Drawing.Point(9, 11);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(122, 27);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "HH:MM:SS";
            // 
            // timer_menu
            // 
            this.timer_menu.Tick += new System.EventHandler(this.timer_menu_Tick);
            // 
            // timer_time
            // 
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel_props);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_left.ResumeLayout(false);
            this.panel_app_title.ResumeLayout(false);
            this.panel_app_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_app_image)).EndInit();
            this.panel_props.ResumeLayout(false);
            this.panel_props.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_product_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_product_add)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Panel panel_app_title;
        private System.Windows.Forms.Label label_app_title_2;
        private System.Windows.Forms.Label label_app_title;
        private System.Windows.Forms.PictureBox pictureBox_app_image;
        private System.Windows.Forms.Panel panel_props;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_shipments;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Label label_years;
        private System.Windows.Forms.PictureBox button_product_add;
        private System.Windows.Forms.PictureBox button_product_delete;
        private System.Windows.Forms.PictureBox product_update;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Timer timer_menu;
        private System.Windows.Forms.Timer timer_time;
    }
}