namespace ManagementApplication
{
    partial class POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV_POS = new DataGridView();
            LV_Cart = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            BT_Submit = new Button();
            TB_Total = new TextBox();
            label1 = new Label();
            BT_DeleteItem = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_POS).BeginInit();
            SuspendLayout();
            // 
            // DGV_POS
            // 
            DGV_POS.AllowUserToAddRows = false;
            DGV_POS.AllowUserToDeleteRows = false;
            DGV_POS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_POS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_POS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_POS.Location = new Point(4, 39);
            DGV_POS.Name = "DGV_POS";
            DGV_POS.ReadOnly = true;
            DGV_POS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_POS.Size = new Size(983, 675);
            DGV_POS.TabIndex = 0;
            DGV_POS.MouseDown += DGV_POS_MouseDown;
            // 
            // LV_Cart
            // 
            LV_Cart.AllowDrop = true;
            LV_Cart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LV_Cart.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2 });
            LV_Cart.FullRowSelect = true;
            LV_Cart.Location = new Point(993, 39);
            LV_Cart.Name = "LV_Cart";
            LV_Cart.Size = new Size(314, 493);
            LV_Cart.TabIndex = 1;
            LV_Cart.UseCompatibleStateImageBehavior = false;
            LV_Cart.View = View.Details;
            LV_Cart.DragDrop += LV_Cart_DragDrop;
            LV_Cart.DragOver += LV_Cart_DragOver;
            LV_Cart.MouseDown += LV_Cart_MouseDown;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "Name";
            columnHeader0.Width = 80;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "QuantityPerUnit";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 70;
            // 
            // BT_Submit
            // 
            BT_Submit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_Submit.Location = new Point(1214, 652);
            BT_Submit.Name = "BT_Submit";
            BT_Submit.Size = new Size(93, 42);
            BT_Submit.TabIndex = 2;
            BT_Submit.Text = "Submit Order";
            BT_Submit.UseVisualStyleBackColor = true;
            BT_Submit.Click += BT_Submit_Click;
            // 
            // TB_Total
            // 
            TB_Total.Location = new Point(1225, 538);
            TB_Total.Name = "TB_Total";
            TB_Total.ReadOnly = true;
            TB_Total.Size = new Size(82, 23);
            TB_Total.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1187, 541);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Total";
            // 
            // BT_DeleteItem
            // 
            BT_DeleteItem.Location = new Point(993, 541);
            BT_DeleteItem.Name = "BT_DeleteItem";
            BT_DeleteItem.Size = new Size(75, 23);
            BT_DeleteItem.TabIndex = 5;
            BT_DeleteItem.Text = "Delete Item";
            BT_DeleteItem.UseVisualStyleBackColor = true;
            BT_DeleteItem.Click += BT_DeleteItem_Click;
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 716);
            Controls.Add(BT_DeleteItem);
            Controls.Add(label1);
            Controls.Add(TB_Total);
            Controls.Add(BT_Submit);
            Controls.Add(LV_Cart);
            Controls.Add(DGV_POS);
            Name = "POSForm";
            Text = "POSForm";
            ((System.ComponentModel.ISupportInitialize)DGV_POS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_POS;
        private ListView LV_Cart;
        private Button BT_Submit;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox TB_Total;
        private Label label1;
        private Button BT_DeleteItem;
    }
}