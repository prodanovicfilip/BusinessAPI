using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApplication.DTOs;
using ManagementApplication.Entities;
using ManagementApplication.Services;
using ManagementApplication.Utilities;

namespace ManagementApplication
{
    public partial class RegistrationForm : Form
    {
        private readonly IApiService _apiService;
        public RegistrationForm(IApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }
        private async void BT_Submit_Click(object sender, EventArgs e)
        {
            var firstName = TB_FirstName.Text;
            var lastName = TB_LastName.Text;
            var email = TB_Email.Text;
            var username = TB_Username.Text;
            var password = TB_Password.Text;
            if (!Utils.IsValidString(firstName, lastName, email, username, password))
            {
                MessageBox.Show("Missing fields");
                return;
            }
            if (password.Length < 2)
            {
                MessageBox.Show("Weak password");
                return;
            }
            var user = new UserDTO();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.Username = username;
            user.Password = password;

            await _apiService.Create(user,nameof(User));
            MessageBox.Show("Registration Successful");
            this.Close();
        }
    }
}
