namespace Govt.BDPension.Forms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.lblAddUserNote = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblRoledecision = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpId = new System.Windows.Forms.MaskedTextBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUserNote
            // 
            this.lblAddUserNote.AutoSize = true;
            this.lblAddUserNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddUserNote.Location = new System.Drawing.Point(16, 74);
            this.lblAddUserNote.Name = "lblAddUserNote";
            this.lblAddUserNote.Size = new System.Drawing.Size(384, 25);
            this.lblAddUserNote.TabIndex = 14;
            this.lblAddUserNote.Text = "Enter the details for the new system user.";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(14, 32);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(229, 38);
            this.lblAddUser.TabIndex = 13;
            this.lblAddUser.Text = "Add New User";
            // 
            // lblRoledecision
            // 
            this.lblRoledecision.AutoSize = true;
            this.lblRoledecision.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoledecision.Location = new System.Drawing.Point(181, 280);
            this.lblRoledecision.Name = "lblRoledecision";
            this.lblRoledecision.Size = new System.Drawing.Size(120, 25);
            this.lblRoledecision.TabIndex = 16;
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
            this.cmbDepartment.Location = new System.Drawing.Point(313, 280);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(334, 31);
            this.cmbDepartment.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(191, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 25);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(313, 208);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 31);
            this.txtName.TabIndex = 17;
            this.txtName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtName_MaskInputRejected);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(389, 505);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 43;
            this.lblRole.Text = "Role";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(20, 505);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 42);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(309, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Assign a role based on the user\'s respossibility.";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.AutoSize = true;
            this.labelEmployeeId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeId.Location = new System.Drawing.Point(175, 411);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(125, 25);
            this.labelEmployeeId.TabIndex = 51;
            this.labelEmployeeId.Text = "Employee Id";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(201, 347);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 25);
            this.labelPassword.TabIndex = 52;
            this.labelPassword.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSalary.Location = new System.Drawing.Point(313, 341);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(334, 31);
            this.txtSalary.TabIndex = 53;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtEmpId.Location = new System.Drawing.Point(313, 408);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(334, 31);
            this.txtEmpId.TabIndex = 54;
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.Yellow;
            this.btnSave1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.Location = new System.Drawing.Point(673, 517);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(133, 42);
            this.btnSave1.TabIndex = 56;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // AddUser
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRoledecision);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblAddUserNote);
            this.Controls.Add(this.lblAddUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(470, 88);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddUser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUserNote;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblRoledecision;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.MaskedTextBox txtSalary;
        private System.Windows.Forms.MaskedTextBox txtEmpId;
        private System.Windows.Forms.Button btnSave1;
    }
}