using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApplication.Entities;
using ManagementApplication.Services;
using ManagementApplication.Utilities;
using Microsoft.EntityFrameworkCore;

namespace ManagementApplication
{
    public partial class UserProfile : Form
    {
        private readonly IApiService _apiService;
        private User _currentUser;
        public UserProfile(IApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
            _currentUser = UserController.CurrentUser;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                TB_FirstName.Text = _currentUser.FirstName;
                TB_LastName.Text = _currentUser.LastName;
                TB_Email.Text = _currentUser.Email;
                TB_Username.Text = _currentUser.Username;
                TB_Password.Text = _currentUser.Password;
            }
        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            string firstName = TB_FirstName.Text;
            string lastName = TB_LastName.Text;
            string email = TB_Email.Text;
            string username = TB_Username.Text;
            string password = TB_Password.Text;
            if (!Utils.IsValidString(firstName, lastName, email, username, password))
            {
                MessageBox.Show("ERROR: field missing");
                return;
            }
            if (_currentUser != null)
            {
                _currentUser.FirstName = firstName;
                _currentUser.FirstName = lastName;
                _currentUser.Email = email;
                _currentUser.Username = username;
                _currentUser.Password = password;
                _currentUser.DateModified = DateTime.Now;

                _apiService.Update(_currentUser.Id, _currentUser, nameof(User));
                MessageBox.Show("success");
            }     
        }
    }
}
