namespace Govt.BDPension.Forms
{
    partial class UserRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoleForm));
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.lblRoleShow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlChoiceBar = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.lblRoledecision = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblUserAcessNote = new System.Windows.Forms.Label();
            this.lblUserAccess = new System.Windows.Forms.Label();
            this.pnlChoiceBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(478, 719);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 21);
            this.lblRole.TabIndex = 53;
            this.lblRole.Text = "Role";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1012, 713);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 34);
            this.btnLogout.TabIndex = 52;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(775, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 28);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDlt
            // 
            this.btnDlt.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.Location = new System.Drawing.Point(879, 14);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(89, 28);
            this.btnDlt.TabIndex = 49;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(994, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 28);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(964, 20);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(61, 17);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "STATUS";
            // 
            // lblRoleShow
            // 
            this.lblRoleShow.AutoSize = true;
            this.lblRoleShow.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleShow.Location = new System.Drawing.Point(730, 20);
            this.lblRoleShow.Name = "lblRoleShow";
            this.lblRoleShow.Size = new System.Drawing.Size(45, 17);
            this.lblRoleShow.TabIndex = 3;
            this.lblRoleShow.Text = "ROLE";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(413, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(12, 20);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 17);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "USER ID";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(25, 713);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlChoiceBar
            // 
            this.pnlChoiceBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlChoiceBar.Controls.Add(this.lblState);
            this.pnlChoiceBar.Controls.Add(this.lblRoleShow);
            this.pnlChoiceBar.Controls.Add(this.lblName);
            this.pnlChoiceBar.Controls.Add(this.lblUserID);
            this.pnlChoiceBar.Location = new System.Drawing.Point(25, 175);
            this.pnlChoiceBar.Name = "pnlChoiceBar";
            this.pnlChoiceBar.Size = new System.Drawing.Size(1105, 54);
            this.pnlChoiceBar.TabIndex = 46;
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(406, 9);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(45, 33);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 21;
            this.picSearch.TabStop = false;
            // 
            // lblRoledecision
            // 
            this.lblRoledecision.AutoSize = true;
            this.lblRoledecision.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoledecision.Location = new System.Drawing.Point(487, 17);
            this.lblRoledecision.Name = "lblRoledecision";
            this.lblRoledecision.Size = new System.Drawing.Size(42, 20);
            this.lblRoledecision.TabIndex = 13;
            this.lblRoledecision.Text = "Role";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Pension Admin",
            "Human Resource Admin",
            "Human Resource Manager",
            "Pension Manager",
            "Employee",
            "Viewer"});
            this.cmbDept.Location = new System.Drawing.Point(536, 14);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(134, 28);
            this.cmbDept.TabIndex = 12;
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.Location = new System.Drawing.Point(11, 17);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(152, 20);
            this.lblSearchEmployee.TabIndex = 11;
            this.lblSearchEmployee.Text = "Search employee ID";
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSearchBar.Controls.Add(this.picSearch);
            this.pnlSearchBar.Controls.Add(this.lblRoledecision);
            this.pnlSearchBar.Controls.Add(this.btnEdit);
            this.pnlSearchBar.Controls.Add(this.cmbDept);
            this.pnlSearchBar.Controls.Add(this.btnDlt);
            this.pnlSearchBar.Controls.Add(this.btnAdd);
            this.pnlSearchBar.Controls.Add(this.lblSearchEmployee);
            this.pnlSearchBar.Controls.Add(this.richTextBox1);
            this.pnlSearchBar.Location = new System.Drawing.Point(25, 115);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(1105, 54);
            this.pnlSearchBar.TabIndex = 45;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(182, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 33);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // lblUserAcessNote
            // 
            this.lblUserAcessNote.AutoSize = true;
            this.lblUserAcessNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAcessNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAcessNote.Location = new System.Drawing.Point(21, 57);
            this.lblUserAcessNote.Name = "lblUserAcessNote";
            this.lblUserAcessNote.Size = new System.Drawing.Size(569, 20);
            this.lblUserAcessNote.TabIndex = 44;
            this.lblUserAcessNote.Text = "Manage system access, user accounts, and permissions for the penssion portal.";
            // 
            // lblUserAccess
            // 
            this.lblUserAccess.AutoSize = true;
            this.lblUserAccess.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAccess.Location = new System.Drawing.Point(19, 24);
            this.lblUserAccess.Name = "lblUserAccess";
            this.lblUserAccess.Size = new System.Drawing.Size(269, 33);
            this.lblUserAccess.TabIndex = 43;
            this.lblUserAccess.Text = "User Access Control";
            // 
            // UserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 770);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlChoiceBar);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.lblUserAcessNote);
            this.Controls.Add(this.lblUserAccess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRoleForm";
            this.Text = "UserRoleForm";
            this.Load += new System.EventHandler(this.UserRoleForm_Load);
            this.pnlChoiceBar.ResumeLayout(false);
            this.pnlChoiceBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblRoleShow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlChoiceBar;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblRoledecision;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblUserAcessNote;
        private System.Windows.Forms.Label lblUserAccess;
    }
}