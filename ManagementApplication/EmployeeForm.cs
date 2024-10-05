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

namespace ManagementApplication
{
    public partial class EmployeeForm : Form
    {
        private List<EmployeeDTO> _employeeDTOs;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public void Setup(IEnumerable<EmployeeDTO> employees)
        {
            _employeeDTOs = employees.ToList();
            DGV_Employees.DataSource = _employeeDTOs;
        }
    }
}
