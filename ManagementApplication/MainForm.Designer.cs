namespace ManagementApplication
{
    partial class MainForm
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
            BT_UserProfile = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            BT_Delete = new Button();
            BT_Add = new Button();
            BT_Manage = new Button();
            groupBox2 = new GroupBox();
            BT_Refresh = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BT_UserProfile
            // 
            BT_UserProfile.Location = new Point(903, 12);
            BT_UserProfile.Name = "BT_UserProfile";
            BT_UserProfile.Size = new Size(92, 37);
            BT_UserProfile.TabIndex = 0;
            BT_UserProfile.Text = "User Profile";
            BT_UserProfile.UseVisualStyleBackColor = true;
            BT_UserProfile.Click += BT_UserProfile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(38, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(859, 543);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clients";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(853, 521);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // BT_Delete
            // 
            BT_Delete.Location = new Point(6, 51);
            BT_Delete.Name = "BT_Delete";
            BT_Delete.Size = new Size(75, 23);
            BT_Delete.TabIndex = 2;
            BT_Delete.Text = "Delete";
            BT_Delete.UseVisualStyleBackColor = true;
            BT_Delete.Click += BT_Delete_Click;
            // 
            // BT_Add
            // 
            BT_Add.Location = new Point(6, 22);
            BT_Add.Name = "BT_Add";
            BT_Add.Size = new Size(75, 23);
            BT_Add.TabIndex = 3;
            BT_Add.Text = "Add";
            BT_Add.UseVisualStyleBackColor = true;
            BT_Add.Click += BT_Add_Click;
            // 
            // BT_Manage
            // 
            BT_Manage.Location = new Point(767, 12);
            BT_Manage.Name = "BT_Manage";
            BT_Manage.Size = new Size(127, 37);
            BT_Manage.TabIndex = 4;
            BT_Manage.Text = "User Management";
            BT_Manage.UseVisualStyleBackColor = true;
            BT_Manage.Click += BT_Manage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BT_Refresh);
            groupBox2.Controls.Add(BT_Delete);
            groupBox2.Controls.Add(BT_Add);
            groupBox2.Location = new Point(903, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(92, 216);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // BT_Refresh
            // 
            BT_Refresh.Location = new Point(6, 80);
            BT_Refresh.Name = "BT_Refresh";
            BT_Refresh.Size = new Size(75, 23);
            BT_Refresh.TabIndex = 4;
            BT_Refresh.Text = "Refresh";
            BT_Refresh.UseVisualStyleBackColor = true;
            BT_Refresh.Click += BT_Refresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 603);
            Controls.Add(groupBox2);
            Controls.Add(BT_Manage);
            Controls.Add(groupBox1);
            Controls.Add(BT_UserProfile);
            Name = "MainForm";
            Text = "Main";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BT_UserProfile;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button BT_Delete;
        private Button BT_Add;
        private Button BT_Manage;
        private GroupBox groupBox2;
        private Button BT_Refresh;
    }
}