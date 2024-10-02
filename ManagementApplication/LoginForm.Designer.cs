namespace ManagementApplication
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_Username = new TextBox();
            TB_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BT_Login = new Button();
            BT_Register = new Button();
            SuspendLayout();
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(148, 47);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(193, 23);
            TB_Username.TabIndex = 0;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(147, 81);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(194, 23);
            TB_Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 50);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // BT_Login
            // 
            BT_Login.Location = new Point(148, 122);
            BT_Login.Name = "BT_Login";
            BT_Login.Size = new Size(75, 23);
            BT_Login.TabIndex = 4;
            BT_Login.Text = "Login";
            BT_Login.UseVisualStyleBackColor = true;
            BT_Login.Click += BT_Login_Click;
            // 
            // BT_Register
            // 
            BT_Register.Location = new Point(229, 122);
            BT_Register.Name = "BT_Register";
            BT_Register.Size = new Size(75, 23);
            BT_Register.TabIndex = 5;
            BT_Register.Text = "Register";
            BT_Register.UseVisualStyleBackColor = true;
            BT_Register.Click += BT_Register_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 202);
            Controls.Add(BT_Register);
            Controls.Add(BT_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_Password);
            Controls.Add(TB_Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Username;
        private TextBox TB_Password;
        private Label label1;
        private Label label2;
        private Button BT_Login;
        private Button BT_Register;
    }
}
