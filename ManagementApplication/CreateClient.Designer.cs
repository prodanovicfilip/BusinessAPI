namespace ManagementApplication
{
    partial class CreateClient
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
            TB_Address = new TextBox();
            TB_Email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BT_Create = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(TB_FirstName);
            flowLayoutPanel1.Controls.Add(TB_LastName);
            flowLayoutPanel1.Controls.Add(TB_Address);
            flowLayoutPanel1.Controls.Add(TB_Email);
            flowLayoutPanel1.Location = new Point(155, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(208, 153);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // TB_FirstName
            // 
            TB_FirstName.Location = new Point(3, 3);
            TB_FirstName.Name = "TB_FirstName";
            TB_FirstName.Size = new Size(163, 23);
            TB_FirstName.TabIndex = 0;
            // 
            // TB_LastName
            // 
            TB_LastName.Location = new Point(3, 32);
            TB_LastName.Name = "TB_LastName";
            TB_LastName.Size = new Size(163, 23);
            TB_LastName.TabIndex = 1;
            // 
            // TB_Address
            // 
            TB_Address.Location = new Point(3, 61);
            TB_Address.Name = "TB_Address";
            TB_Address.Size = new Size(163, 23);
            TB_Address.TabIndex = 2;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(3, 90);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(163, 23);
            TB_Email.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 77);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 135);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // BT_Create
            // 
            BT_Create.Location = new Point(155, 216);
            BT_Create.Name = "BT_Create";
            BT_Create.Size = new Size(75, 23);
            BT_Create.TabIndex = 5;
            BT_Create.Text = "Create";
            BT_Create.UseVisualStyleBackColor = true;
            BT_Create.Click += BT_Create_Click;
            // 
            // CreateClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 298);
            Controls.Add(BT_Create);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateClient";
            Text = "CreateClient";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox TB_FirstName;
        private TextBox TB_LastName;
        private TextBox TB_Address;
        private TextBox TB_Email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BT_Create;
    }
}