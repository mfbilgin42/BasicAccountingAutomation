using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class DashboardForm : Form
    {
        private int panelWidth;
        bool isCollapsed;

        public DashboardForm()
        {
            InitializeComponent();
            panelWidth = panel_left.Width;
            isCollapsed = false;
            timer_time.Start();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_left.Width += 10;
                if (panel_left.Width >= panelWidth)
                {
                    timer_menu.Stop();
                    isCollapsed = false;
                    Refresh();
                }
                    
            }
            else
            {
                panel_left.Width -= 10;
                if (panel_left.Width <= 60)
                {
                    timer_menu.Stop();
                    isCollapsed = true;
                    Refresh();
                }
            }
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            pictureBox_app_image.Visible = !pictureBox_app_image.Visible;
            label_app_title.Visible = !label_app_title.Visible;
            label_app_title_2.Visible = !label_app_title_2.Visible;
            timer_menu.Start();
        }
        private void MoveSidePanel(Control button)
        {
            panel_side.Height = button.Height;
            panel_side.Top = button.Top;

        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            label_time.Text = dateTime.ToString("HH:MM:ss");
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button_products);
        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button_orders);
        }

        private void button_shipments_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button_shipments);
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button_customers);
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            MoveSidePanel(button_settings);
        }
    }
}
