namespace ManagementApplication
{
    partial class RegistrationForm
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
            TB_FirstName = new TextBox();
            TB_LastName = new TextBox();
            TB_Username = new TextBox();
            TB_Email = new TextBox();
            TB_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            BT_Submit = new Button();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // TB_FirstName
            // 
            TB_FirstName.Location = new Point(3, 3);
            TB_FirstName.Name = "TB_FirstName";
            TB_FirstName.Size = new Size(115, 23);
            TB_FirstName.TabIndex = 0;
            // 
            // TB_LastName
            // 
            TB_LastName.Location = new Point(3, 32);
            TB_LastName.Name = "TB_LastName";
            TB_LastName.Size = new Size(115, 23);
            TB_LastName.TabIndex = 1;
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(3, 61);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(115, 23);
            TB_Username.TabIndex = 2;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(3, 90);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(115, 23);
            TB_Email.TabIndex = 3;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(3, 119);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(115, 23);
            TB_Password.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 63);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 92);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 121);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 150);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(TB_FirstName);
            flowLayoutPanel2.Controls.Add(TB_LastName);
            flowLayoutPanel2.Controls.Add(TB_Username);
            flowLayoutPanel2.Controls.Add(TB_Email);
            flowLayoutPanel2.Controls.Add(TB_Password);
            flowLayoutPanel2.Location = new Point(140, 28);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(133, 147);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // BT_Submit
            // 
            BT_Submit.Location = new Point(129, 191);
            BT_Submit.Name = "BT_Submit";
            BT_Submit.Size = new Size(75, 23);
            BT_Submit.TabIndex = 12;
            BT_Submit.Text = "Register";
            BT_Submit.UseVisualStyleBackColor = true;
            BT_Submit.Click += BT_Submit_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 226);
            Controls.Add(BT_Submit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationForm";
            Text = "Registration";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_FirstName;
        private TextBox TB_LastName;
        private TextBox TB_Username;
        private TextBox TB_Email;
        private TextBox TB_Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button BT_Submit;
    }
}