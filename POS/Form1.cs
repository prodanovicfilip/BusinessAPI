using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataAccess;
using POS.Entities;
using POS.Queries;

namespace POS
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private List<Product> _products;
        private List<Product> _products_shop = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var context = new DataService();
            _products = context.LoadData<Product, object>(ProductQuery.GetAll, new { }).ToList();
            GC_Products.DataSource = _products;
            GC_Cart.DataSource = _products_shop;
        }

        private void GC_Products_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void GC_Products_DragOver(object sender, DragEventArgs e)
        {

        }
    }
}
