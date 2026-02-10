namespace Govt.BDPension.Forms
{
    partial class Edit1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave1 = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.MaskedTextBox();
            this.txtSalary = new System.Windows.Forms.MaskedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.lblRoledecision = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblAddUserNote = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.Yellow;
            this.btnSave1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.Location = new System.Drawing.Point(662, 485);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(133, 42);
            this.btnSave1.TabIndex = 84;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpId.Location = new System.Drawing.Point(302, 376);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(334, 31);
            this.txtEmpId.TabIndex = 83;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSalary.Location = new System.Drawing.Point(302, 309);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(334, 31);
            this.txtSalary.TabIndex = 82;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(190, 315);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 25);
            this.labelPassword.TabIndex = 81;
            this.labelPassword.Text = "Salary";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeId.Location = new System.Drawing.Point(164, 379);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(125, 25);
            this.labelEmployeeId.TabIndex = 80;
            this.labelEmployeeId.Text = "Employee Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(312, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Assign a role based on the user\'s respossibility.";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(439, 466);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 78;
            this.lblRole.Text = "Role";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(180, 179);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 25);
            this.lblName.TabIndex = 77;
            this.lblName.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(302, 176);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 31);
            this.txtName.TabIndex = 76;
            // 
            // lblRoledecision
            // 
            this.lblRoledecision.AutoSize = true;
            this.lblRoledecision.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoledecision.Location = new System.Drawing.Point(170, 248);
            this.lblRoledecision.Name = "lblRoledecision";
            this.lblRoledecision.Size = new System.Drawing.Size(120, 25);
            this.lblRoledecision.TabIndex = 75;
            this.lblRoledecision.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "HR",
            "Finance",
            "IT & Operation",
            "Public Relation"});
            this.cmbDepartment.Location = new System.Drawing.Point(302, 248);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(334, 31);
            this.cmbDepartment.TabIndex = 74;
            // 
            // lblAddUserNote
            // 
            this.lblAddUserNote.AutoSize = true;
            this.lblAddUserNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddUserNote.Location = new System.Drawing.Point(5, 42);
            this.lblAddUserNote.Name = "lblAddUserNote";
            this.lblAddUserNote.Size = new System.Drawing.Size(384, 25);
            this.lblAddUserNote.TabIndex = 73;
            this.lblAddUserNote.Text = "Enter the details for the new system user.";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(3, 0);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(155, 38);
            this.lblAddUser.TabIndex = 72;
            this.lblAddUser.Text = "Edit User";
            // 
            // Edit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRoledecision);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblAddUserNote);
            this.Controls.Add(this.lblAddUser);
            this.Name = "Edit1";
            this.Size = new System.Drawing.Size(840, 784);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.MaskedTextBox txtEmpId;
        private System.Windows.Forms.MaskedTextBox txtSalary;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.Label lblRoledecision;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblAddUserNote;
        private System.Windows.Forms.Label lblAddUser;
    }
}
