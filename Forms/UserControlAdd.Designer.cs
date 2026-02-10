namespace Govt.BDPension.Forms
{
    partial class UserControlAdd
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
            this.btnSave1 = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.MaskedTextBox();
            this.txtSalary = new System.Windows.Forms.MaskedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.btnSave1.Location = new System.Drawing.Point(670, 463);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(133, 42);
            this.btnSave1.TabIndex = 71;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpId.Location = new System.Drawing.Point(310, 354);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(334, 31);
            this.txtEmpId.TabIndex = 69;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSalary.Location = new System.Drawing.Point(310, 287);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(334, 31);
            this.txtSalary.TabIndex = 68;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(198, 293);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 25);
            this.labelPassword.TabIndex = 67;
            this.labelPassword.Text = "Password";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeId.Location = new System.Drawing.Point(172, 357);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(125, 25);
            this.labelEmployeeId.TabIndex = 66;
            this.labelEmployeeId.Text = "Employee Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(306, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Assign a role based on the user\'s respossibility.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(-3, -54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 70;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(386, 451);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 63;
            this.lblRole.Text = "Role";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(188, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 25);
            this.lblName.TabIndex = 62;
            this.lblName.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(310, 154);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 31);
            this.txtName.TabIndex = 61;
            // 
            // lblRoledecision
            // 
            this.lblRoledecision.AutoSize = true;
            this.lblRoledecision.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoledecision.Location = new System.Drawing.Point(178, 226);
            this.lblRoledecision.Name = "lblRoledecision";
            this.lblRoledecision.Size = new System.Drawing.Size(99, 25);
            this.lblRoledecision.TabIndex = 60;
            this.lblRoledecision.Text = "User Role";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Pension Admin",
            "Pension Manager",
            "Viewer"});
            this.cmbDepartment.Location = new System.Drawing.Point(310, 226);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(334, 31);
            this.cmbDepartment.TabIndex = 59;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblAddUserNote
            // 
            this.lblAddUserNote.AutoSize = true;
            this.lblAddUserNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddUserNote.Location = new System.Drawing.Point(-1, 49);
            this.lblAddUserNote.Name = "lblAddUserNote";
            this.lblAddUserNote.Size = new System.Drawing.Size(384, 25);
            this.lblAddUserNote.TabIndex = 58;
            this.lblAddUserNote.Text = "Enter the details for the new system user.";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(-3, 9);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(229, 38);
            this.lblAddUser.TabIndex = 57;
            this.lblAddUser.Text = "Add New User";
            this.lblAddUser.Click += new System.EventHandler(this.lblAddUser_Click);
            // 
            // UserControlAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 728);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRoledecision);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblAddUserNote);
            this.Controls.Add(this.lblAddUser);
            this.Location = new System.Drawing.Point(470, 88);
            this.Name = "UserControlAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserControlAdd";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserControlAdd_Load);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.Label lblRoledecision;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblAddUserNote;
        private System.Windows.Forms.Label lblAddUser;
    }
}