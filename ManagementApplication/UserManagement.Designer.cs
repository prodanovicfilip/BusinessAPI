namespace ManagementApplication
{
    partial class UserManagement
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
            DGV_Users = new DataGridView();
            BT_Add = new Button();
            BT_Delete = new Button();
            BT_Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Users).BeginInit();
            SuspendLayout();
            // 
            // DGV_Users
            // 
            DGV_Users.AllowUserToAddRows = false;
            DGV_Users.AllowUserToDeleteRows = false;
            DGV_Users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Users.Location = new Point(0, 94);
            DGV_Users.Name = "DGV_Users";
            DGV_Users.ReadOnly = true;
            DGV_Users.Size = new Size(817, 423);
            DGV_Users.TabIndex = 0;
            DGV_Users.MouseDown += DGV_Users_MouseDown;
            // 
            // BT_Add
            // 
            BT_Add.Location = new Point(836, 106);
            BT_Add.Name = "BT_Add";
            BT_Add.Size = new Size(105, 30);
            BT_Add.TabIndex = 1;
            BT_Add.Text = "Add";
            BT_Add.UseVisualStyleBackColor = true;
            BT_Add.Click += BT_Add_Click;
            // 
            // BT_Delete
            // 
            BT_Delete.Location = new Point(836, 142);
            BT_Delete.Name = "BT_Delete";
            BT_Delete.Size = new Size(105, 30);
            BT_Delete.TabIndex = 2;
            BT_Delete.Text = "Delete";
            BT_Delete.UseVisualStyleBackColor = true;
            BT_Delete.Click += BT_Delete_Click;
            // 
            // BT_Refresh
            // 
            BT_Refresh.Location = new Point(836, 178);
            BT_Refresh.Name = "BT_Refresh";
            BT_Refresh.Size = new Size(105, 30);
            BT_Refresh.TabIndex = 3;
            BT_Refresh.Text = "Refresh";
            BT_Refresh.UseVisualStyleBackColor = true;
            BT_Refresh.Click += BT_Refresh_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 519);
            Controls.Add(BT_Refresh);
            Controls.Add(BT_Delete);
            Controls.Add(BT_Add);
            Controls.Add(DGV_Users);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Users;
        private Button BT_Add;
        private Button BT_Delete;
        private Button BT_Refresh;
    }
}