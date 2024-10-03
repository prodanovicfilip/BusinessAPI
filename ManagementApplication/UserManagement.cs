using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApplication.Entities;
using ManagementApplication.Services;
using ManagementApplication.Utilities;

namespace ManagementApplication
{
    public partial class UserManagement : Form
    {
        private readonly IApiService _apiService;
        private User _user;
        private List<User> _users;
        public UserManagement(IApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private async void UserManagement_Load(object sender, EventArgs e)
        {
            _users = (await _apiService.GetAll<User>(nameof(User))).ToList();
            DGV_Users.DataSource = _users;
            if (_users.Count > 0)
            {
                DGV_Users.Rows[0].Selected = true;
                _user = _users[0];
            }
        }

        private async void BT_Delete_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                if (_user.Id == UserController.CurrentUser.Id)
                {
                    MessageBox.Show("Can't delete current user.");
                    return;
                }
                _users.Remove(_user);
                await _apiService.Delete<User>(_user.Id, nameof(User));
            }
            DGV_Users.DataSource = null;
            DGV_Users.DataSource = _users;
        }
        private async void BT_Add_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<RegistrationForm>();
            form.ShowDialog();
            _users = (await _apiService.GetAll<User>(nameof(User))).ToList();
            DGV_Users.DataSource = _users;
        }
        private void DGV_Users_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_Users.HitTest(e.X, e.Y);
            DGV_Users.ClearSelection();
            DGV_Users.Rows[hit.RowIndex].Selected = true;
            _user = _users[hit.RowIndex];
        }

        private async void BT_Refresh_Click(object sender, EventArgs e)
        {
            _users = (await _apiService.GetAll<User>(nameof(User))).ToList();
            if (_users != null)
            {
                DGV_Users.DataSource = _users;
            }
        }
    }
}
