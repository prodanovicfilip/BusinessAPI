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
    public partial class CreateClient : Form
    {
        private readonly IApiService _apiService;
        public CreateClient(IApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
        }

        private async void BT_Create_Click(object sender, EventArgs e)
        {
            var firstName = TB_FirstName.Text;
            var lastName = TB_LastName.Text;
            var email = TB_Email.Text;
            var address = TB_Address.Text;
            if (!Utils.IsValidString(firstName, lastName, email, address))
            {
                MessageBox.Show("Missing fields");
                return;
            }
            var client = new ClientDTO();
            client.FirstName = firstName;
            client.LastName = lastName;
            client.Email = email;
            client.Address = address;

            await _apiService.Create(client, nameof(Client));
            MessageBox.Show("Client added");
            this.Close();
        }
    }
}
