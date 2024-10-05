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
            listView1 = new ListView();
            BT_Submit = new Button();
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
            DGV_POS.Size = new Size(927, 675);
            DGV_POS.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listView1.Location = new Point(942, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(172, 374);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BT_Submit
            // 
            BT_Submit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_Submit.Location = new Point(982, 416);
            BT_Submit.Name = "BT_Submit";
            BT_Submit.Size = new Size(93, 42);
            BT_Submit.TabIndex = 2;
            BT_Submit.Text = "Submit Order";
            BT_Submit.UseVisualStyleBackColor = true;
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 716);
            Controls.Add(BT_Submit);
            Controls.Add(listView1);
            Controls.Add(DGV_POS);
            Name = "POSForm";
            Text = "POSForm";
            ((System.ComponentModel.ISupportInitialize)DGV_POS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_POS;
        private ListView listView1;
        private Button BT_Submit;
    }
}