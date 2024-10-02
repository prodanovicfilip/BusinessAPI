namespace ManagementApplication
{
    partial class UserProfile
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            TB_FirstName = new TextBox();
            TB_LastName = new TextBox();
            TB_Email = new TextBox();
            TB_Username = new TextBox();
            TB_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BT_Update = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(TB_FirstName);
            flowLayoutPanel1.Controls.Add(TB_LastName);
            flowLayoutPanel1.Controls.Add(TB_Email);
            flowLayoutPanel1.Controls.Add(TB_Username);
            flowLayoutPanel1.Controls.Add(TB_Password);
            flowLayoutPanel1.Location = new Point(151, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(166, 157);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // TB_FirstName
            // 
            TB_FirstName.Location = new Point(3, 3);
            TB_FirstName.Name = "TB_FirstName";
            TB_FirstName.Size = new Size(144, 23);
            TB_FirstName.TabIndex = 0;
            // 
            // TB_LastName
            // 
            TB_LastName.Location = new Point(3, 32);
            TB_LastName.Name = "TB_LastName";
            TB_LastName.Size = new Size(144, 23);
            TB_LastName.TabIndex = 1;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(3, 61);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(144, 23);
            TB_Email.TabIndex = 2;
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(3, 90);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(144, 23);
            TB_Username.TabIndex = 3;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(3, 119);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(144, 23);
            TB_Password.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 100);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 129);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 158);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // BT_Update
            // 
            BT_Update.Location = new Point(223, 199);
            BT_Update.Name = "BT_Update";
            BT_Update.Size = new Size(75, 23);
            BT_Update.TabIndex = 6;
            BT_Update.Text = "Update";
            BT_Update.UseVisualStyleBackColor = true;
            BT_Update.Click += BT_Update_Click;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 277);
            Controls.Add(BT_Update);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox TB_FirstName;
        private TextBox TB_LastName;
        private TextBox TB_Email;
        private TextBox TB_Username;
        private TextBox TB_Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BT_Update;
    }
}