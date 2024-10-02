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

namespace ManagementApplication
{
    public partial class MainForm : Form
    {
        private Client _client;
        private List<Client> _clients;
        private readonly IApiService _apiService;
        public MainForm(IApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private void BT_UserProfile_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<UserProfile>();
            form.ShowDialog();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            _clients = (await _apiService.GetAll<Client>(nameof(Client))).ToList();
            dataGridView1.DataSource = _clients;
            if (_clients.Count > 0 )
            {
                dataGridView1.Rows[0].Selected = true;
                _client = _clients.ToList()[0];
            }
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if (_client != null)
            {
                _clients.Remove(_client);
                _apiService.Delete<Client>(_client.Id, nameof(Client));
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _clients;
        }

        private void BT_Manage_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<UserManagement>();
            form.ShowDialog();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[hit.RowIndex].Selected = true;
            _client = _clients.ToList()[hit.RowIndex];
        }

        private async void BT_Add_Click(object sender, EventArgs e)
        {
            var form = Program.GetService<CreateClient>();
            form.ShowDialog();
            _clients = (await _apiService.GetAll<Client>(nameof(Client))).ToList();
            dataGridView1.DataSource = _clients;
        }

        private async void BT_Refresh_Click(object sender, EventArgs e)
        {
            _clients = (await _apiService.GetAll<Client>(nameof(Client))).ToList();
            if (_clients != null)
            {
                dataGridView1.DataSource = _clients;
            }
        }
    }
}
