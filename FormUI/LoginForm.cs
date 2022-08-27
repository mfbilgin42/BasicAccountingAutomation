using Business.Abstract;
using Entities.Dtos;
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
    public partial class Form_Login : Form
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        public Form_Login(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;

            InitializeComponent();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            button_hide_password.Visible = false;
            var result = _userService.GetAll().Data;
            textBox_user_name.Text = result[0].UserName;
            if (result.Count < 1)
            {
                Close();
                //!!! Create Toast !!!
                //!!! Open Register Form!!!
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
            UserForAuthDto userForAuthDto = new UserForAuthDto
            {
                UserName = textBox_user_name.Text,
                Password = textBox_password.Text

            };
            var result = _authService.Login(userForAuthDto);
            
        }
    }
}
