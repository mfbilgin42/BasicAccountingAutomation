using Business.Abstract;
using Entities.Dtos;
using FormUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        public LoginForm(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;

            InitializeComponent();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            button_hide_password.Visible = false;
            var result = _userService.GetAll().Data;
            if (result.Count < 1)
            {
                using (RegisterForm registerForm = new RegisterForm(_authService,_userService))
                {
                    registerForm.Show();
                }

            }
            else
            {
                textBox_user_name.Text = result[0].UserName;
            }
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_collaps_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_show_password_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            button_show_password.Visible = false;
            button_hide_password.Visible = true;

        }

        private void button_hide_password_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            button_show_password.Visible = true;
            button_hide_password.Visible = false;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void Login()
        {
            var result = _authService.Login(CreateUser());
            if (result.Success)
            {
                using (DashboardForm dashboardForm = new DashboardForm())
                {
                    dashboardForm.ShowDialog();
                }
                Close();
            }
            //MessageBox.Show(result.Message);
        }

        private UserForAuthDto CreateUser()
        {
            return new UserForAuthDto
            {
                UserName = textBox_user_name.Text,
                Password = textBox_password.Text

            };
        }

        private void pictureBox_user_Click(object sender, EventArgs e)
        {
            textBox_user_name.Text = _userService.GetAll().Data[0].UserName.ToString();
        }
        private void textBox_password_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Login();
            }
        }

        private void textBox_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Login();
            }
        }
    }
}
