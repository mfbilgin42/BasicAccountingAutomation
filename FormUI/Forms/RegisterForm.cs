using Business.Abstract;
using Entities.Dtos;
using System;
using System.Windows.Forms;

namespace FormUI
{
    public partial class RegisterForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;

        public RegisterForm(IAuthService authService,IUserService userService)
        {
            InitializeComponent();
            _authService = authService;
            _userService = userService;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            textBox_user_name.Text = "admin";
            button_hide_password.Visible = false;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_collaps_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_hide_password_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            button_show_password.Visible = true;
            button_hide_password.Visible = false;
        }

        private void button_show_password_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            button_show_password.Visible = false;
            button_hide_password.Visible = true;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register();
        }
        private void Register()
        {
            UserForAuthDto userForAuthDto = new UserForAuthDto
            {
                UserName = textBox_user_name.Text,
                Password = textBox_password.Text

            };
            var result = _authService.Register(userForAuthDto);
            if (result.Success)
            {
                using (LoginForm loginForm = new LoginForm(_userService,_authService))
                {
                    loginForm.Show();
                }
                Close();
            }
            MessageBox.Show(result.Message);
        }

        private void pictureBox_user_Click(object sender, EventArgs e)
        {
            textBox_user_name.Text = "admin";
        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }
    }
}
