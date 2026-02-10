namespace Govt.BDPension.Forms
{
    partial class ViewEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmp));
            this.lblEmpDictory = new System.Windows.Forms.Label();
            this.lblEmpDicNote = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cmbSatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeptr = new System.Windows.Forms.Label();
            this.pnlChoiceBar = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            this.pnlChoiceBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpDictory
            // 
            this.lblEmpDictory.AutoSize = true;
            this.lblEmpDictory.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDictory.Location = new System.Drawing.Point(19, 24);
            this.lblEmpDictory.Name = "lblEmpDictory";
            this.lblEmpDictory.Size = new System.Drawing.Size(271, 33);
            this.lblEmpDictory.TabIndex = 43;
            this.lblEmpDictory.Text = "Employee Directory";
            // 
            // lblEmpDicNote
            // 
            this.lblEmpDicNote.AutoSize = true;
            this.lblEmpDicNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDicNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmpDicNote.Location = new System.Drawing.Point(21, 57);
            this.lblEmpDicNote.Name = "lblEmpDicNote";
            this.lblEmpDicNote.Size = new System.Drawing.Size(450, 20);
            this.lblEmpDicNote.TabIndex = 44;
            this.lblEmpDicNote.Text = "Manage current staff , update records, and handle etorements.";
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
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "1. Finance",
            "2. IT & Operations",
            "3. Human Resources",
            "4. Public Relation"});
            this.cmbDept.Location = new System.Drawing.Point(644, 14);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(134, 28);
            this.cmbDept.TabIndex = 12;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(595, 17);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(43, 20);
            this.lblDept.TabIndex = 13;
            this.lblDept.Text = "Dept";
            // 
            // cmbSatus
            // 
            this.cmbSatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatus.FormattingEnabled = true;
            this.cmbSatus.Items.AddRange(new object[] {
            "1. Pending Approval",
            "2. Processing",
            "3. Ready for Review",
            "4. Not Started"});
            this.cmbSatus.Location = new System.Drawing.Point(953, 14);
            this.cmbSatus.Name = "cmbSatus";
            this.cmbSatus.Size = new System.Drawing.Size(134, 28);
            this.cmbSatus.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(894, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
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
            // pnlSearchBar
            // 
            this.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSearchBar.Controls.Add(this.picSearch);
            this.pnlSearchBar.Controls.Add(this.lblStatus);
            this.pnlSearchBar.Controls.Add(this.cmbSatus);
            this.pnlSearchBar.Controls.Add(this.lblDept);
            this.pnlSearchBar.Controls.Add(this.cmbDept);
            this.pnlSearchBar.Controls.Add(this.lblSearchEmployee);
            this.pnlSearchBar.Controls.Add(this.richTextBox1);
            this.pnlSearchBar.Location = new System.Drawing.Point(25, 115);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(1105, 54);
            this.pnlSearchBar.TabIndex = 45;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(12, 20);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(103, 17);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "EMPLOYEE ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(357, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            // 
            // lblDeptr
            // 
            this.lblDeptr.AutoSize = true;
            this.lblDeptr.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptr.Location = new System.Drawing.Point(654, 20);
            this.lblDeptr.Name = "lblDeptr";
            this.lblDeptr.Size = new System.Drawing.Size(107, 17);
            this.lblDeptr.TabIndex = 3;
            this.lblDeptr.Text = "DEPARTMENT";
            // 
            // pnlChoiceBar
            // 
            this.pnlChoiceBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlChoiceBar.Controls.Add(this.lblState);
            this.pnlChoiceBar.Controls.Add(this.lblDeptr);
            this.pnlChoiceBar.Controls.Add(this.lblName);
            this.pnlChoiceBar.Controls.Add(this.lblEmpID);
            this.pnlChoiceBar.Location = new System.Drawing.Point(25, 175);
            this.pnlChoiceBar.Name = "pnlChoiceBar";
            this.pnlChoiceBar.Size = new System.Drawing.Size(1105, 54);
            this.pnlChoiceBar.TabIndex = 46;
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
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(984, 20);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(61, 17);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "STATUS";
            // 
            // ViewEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 770);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlChoiceBar);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.lblEmpDicNote);
            this.Controls.Add(this.lblEmpDictory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewEmp";
            this.Text = "ViewEmp";
            this.Load += new System.EventHandler(this.ViewEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            this.pnlChoiceBar.ResumeLayout(false);
            this.pnlChoiceBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpDictory;
        private System.Windows.Forms.Label lblEmpDicNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cmbSatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDeptr;
        private System.Windows.Forms.Panel pnlChoiceBar;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
    }
}