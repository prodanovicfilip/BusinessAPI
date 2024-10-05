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
    public partial class POSForm : Form
    {
        private List<ProductDTO> _productDTOs;
        public POSForm()
        {
            InitializeComponent();
        }
        public void Setup(IEnumerable<ProductDTO> products)
        {
            _productDTOs = products.ToList();
            DGV_POS.DataSource = _productDTOs;
        }
    }
}
