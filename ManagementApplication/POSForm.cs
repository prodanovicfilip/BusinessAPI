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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementApplication
{
    public partial class POSForm : Form
    {
        private List<ProductDTO> _productDTOs;
        private ProductDTO _selectedProduct;
        private List<ProductDTO> _productCart = new List<ProductDTO>();
        private List<ProductDTO> _productsCache = new List<ProductDTO>();
        private ListViewItem _selectedCartItem;
        public POSForm()
        {
            InitializeComponent();
        }
        public void Setup(IEnumerable<ProductDTO> products)
        {
            _productDTOs = products.ToList();
            DGV_POS.DataSource = _productDTOs;
            //SetupListView();
        }
        private void SetupListView()
        {
            ListViewItem lv = new ListViewItem();
            var properties = typeof(ProductDTO).GetProperties();
            foreach (var property in properties)
            {
                if (property.Name == nameof(ProductDTO.ProductName))
                {
                    lv.Text = property.Name;
                }
                if (property.Name == nameof(ProductDTO.UnitPrice))
                {
                    lv.SubItems.Add(property.Name);
                }
            }
            LV_Cart.Items.Add(lv);
        }

        private void DGV_POS_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = DGV_POS.HitTest(e.X, e.Y);
            DGV_POS.ClearSelection();
            if (hit.RowIndex != -1)
            {
                DGV_POS.Rows[hit.RowIndex].Selected = true;
                _selectedProduct = _productDTOs.ToList()[hit.RowIndex];
                if (hit.RowIndex >= 0)
                {
                    // Start dragging the row
                    DGV_POS.DoDragDrop(DGV_POS.Rows[hit.RowIndex], DragDropEffects.Move);
                }
            }
        }

        private void LV_Cart_DragOver(object sender, DragEventArgs e)
        {
            // Check if the data being dragged is a DataGridViewRow
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void LV_Cart_DragDrop(object sender, DragEventArgs e)
        {
            // Get the row being dragged
            var row = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
            if (row != null)
            {
                //var item = row.Cells[1].Value.ToString();
                //LV_Cart.Items.Add(item);

                // Create a new ListViewItem with the first cell
                var listViewItem = new ListViewItem(row.Cells[1].Value.ToString());

                // Add subitems from other cells
                listViewItem.SubItems.Add(row.Cells[4].Value.ToString()); // Add Cell[4] as a subitem
                listViewItem.SubItems.Add(row.Cells[5].Value.ToString()); // Add Cell[5] as a subitem

                // Add the complete ListViewItem to the ListView
                LV_Cart.Items.Add(listViewItem);
                _productsCache.Add(_selectedProduct);
                var totalPrice = _productsCache.Select(l => l.UnitPrice).Sum();
                TB_Total.Text = totalPrice.ToString();
            }

        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {

        }

        private void BT_DeleteItem_Click(object sender, EventArgs e)
        {
            LV_Cart.Items.Remove(_selectedCartItem);
            if (LV_Cart.Items.Count > 0)
            {
                LV_Cart.FocusedItem = LV_Cart.Items[LV_Cart.Items.Count - 1];
                LV_Cart.Items[LV_Cart.Items.Count - 1].Selected = true;
                LV_Cart.Select();
                _selectedCartItem = LV_Cart.Items[LV_Cart.Items.Count - 1];
            }
        }

        private void LV_Cart_MouseDown(object sender, MouseEventArgs e)
        {
           var hit = LV_Cart.HitTest(e.X, e.Y);
           _selectedCartItem = hit.Item;
        }
    }
}
