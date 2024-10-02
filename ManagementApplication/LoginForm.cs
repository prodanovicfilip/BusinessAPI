using System.Collections.Generic;
using ManagementApplication.Entities;
using ManagementApplication.Services;
using ManagementApplication.Utilities;
using Microsoft.EntityFrameworkCore;

namespace ManagementApplication
{
    public partial class LoginForm : Form
    {
        private readonly IApiService _apiService;
        public LoginForm(IApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private async void BT_Login_Click(object sender, EventArgs e)
        {
            string username = TB_Username.Text;
            string password = TB_Password.Text;

            if (!Utils.IsValidString(username, password))
            {
                MessageBox.Show("Error!");
                return;
            }
            var Users = (await _apiService.GetAll<User>(nameof(User))).ToList();
            if (Users.Where(u => u.Username == username && u.Password == password).Any())
            {
                UserController.CurrentUser = Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                var f = Program.GetService<MainForm>();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("You have entered an invalid username or password");
                return;
            }
        }
        private void BT_Register_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<RegistrationForm>();
            form.ShowDialog();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            var list = (await _apiService.GetAll<User>(nameof(User))).ToList();
            if (!list.Any())
            {
                var form = Program.GetService<RegistrationForm>();
                form.ShowDialog();
            }
        }
    }
}
