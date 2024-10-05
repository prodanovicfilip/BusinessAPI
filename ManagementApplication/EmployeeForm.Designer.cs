namespace ManagementApplication
{
    partial class EmployeeForm
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
            DGV_Employees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGV_Employees).BeginInit();
            SuspendLayout();
            // 
            // DGV_Employees
            // 
            DGV_Employees.AllowUserToAddRows = false;
            DGV_Employees.AllowUserToDeleteRows = false;
            DGV_Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Employees.Dock = DockStyle.Fill;
            DGV_Employees.Location = new Point(0, 0);
            DGV_Employees.Name = "DGV_Employees";
            DGV_Employees.ReadOnly = true;
            DGV_Employees.Size = new Size(800, 450);
            DGV_Employees.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGV_Employees);
            Name = "EmployeeForm";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)DGV_Employees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Employees;
    }
}