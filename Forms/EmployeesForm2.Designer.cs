namespace Govt.BDPension.Forms
{
    partial class EmployeesForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm2));
            this.dgvMngEmp = new System.Windows.Forms.DataGridView();
            this.lblDept = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmpDictory = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.cmbSatus = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmpDicNote = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlAdd1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMngEmp
            // 
            this.dgvMngEmp.AllowUserToAddRows = false;
            this.dgvMngEmp.AllowUserToDeleteRows = false;
            this.dgvMngEmp.AllowUserToResizeColumns = false;
            this.dgvMngEmp.AllowUserToResizeRows = false;
            this.dgvMngEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvMngEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMngEmp.Location = new System.Drawing.Point(10, 255);
            this.dgvMngEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMngEmp.Name = "dgvMngEmp";
            this.dgvMngEmp.ReadOnly = true;
            this.dgvMngEmp.RowHeadersWidth = 51;
            this.dgvMngEmp.RowTemplate.Height = 24;
            this.dgvMngEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMngEmp.Size = new System.Drawing.Size(827, 400);
            this.dgvMngEmp.TabIndex = 61;
            this.dgvMngEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMngEmp_CellContentClick);
            this.dgvMngEmp.DoubleClick += new System.EventHandler(this.dgvMngEmp_doubleClick);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(371, 21);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(55, 25);
            this.lblDept.TabIndex = 13;
            this.lblDept.Text = "Dept";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "1.Pension Admin",
            "2. Pension Manager",
            "3. Employee",
            ""});
            this.cmbDept.Location = new System.Drawing.Point(432, 18);
            this.cmbDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(150, 31);
            this.cmbDept.TabIndex = 12;
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.Location = new System.Drawing.Point(12, 21);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(127, 25);
            this.lblSearchEmployee.TabIndex = 11;
            this.lblSearchEmployee.Text = "Employee ID";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(136, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(156, 31);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(381, 679);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 60;
            this.lblRole.Text = "Role";
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(298, 5);
            this.picSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(51, 41);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 21;
            this.picSearch.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1006, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 25);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // lblEmpDictory
            // 
            this.lblEmpDictory.AutoSize = true;
            this.lblEmpDictory.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDictory.Location = new System.Drawing.Point(20, 44);
            this.lblEmpDictory.Name = "lblEmpDictory";
            this.lblEmpDictory.Size = new System.Drawing.Size(318, 38);
            this.lblEmpDictory.TabIndex = 53;
            this.lblEmpDictory.Text = "Employee Directory";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(704, 663);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 59;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbYear.Location = new System.Drawing.Point(644, 21);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(150, 31);
            this.cmbYear.TabIndex = 22;
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSearchBar.Controls.Add(this.label1);
            this.pnlSearchBar.Controls.Add(this.cmbYear);
            this.pnlSearchBar.Controls.Add(this.picSearch);
            this.pnlSearchBar.Controls.Add(this.lblStatus);
            this.pnlSearchBar.Controls.Add(this.cmbSatus);
            this.pnlSearchBar.Controls.Add(this.lblDept);
            this.pnlSearchBar.Controls.Add(this.cmbDept);
            this.pnlSearchBar.Controls.Add(this.lblSearchEmployee);
            this.pnlSearchBar.Controls.Add(this.richTextBox1);
            this.pnlSearchBar.Location = new System.Drawing.Point(10, 179);
            this.pnlSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(840, 68);
            this.pnlSearchBar.TabIndex = 55;
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
            this.cmbSatus.Location = new System.Drawing.Point(1072, 18);
            this.cmbSatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSatus.Name = "cmbSatus";
            this.cmbSatus.Size = new System.Drawing.Size(150, 31);
            this.cmbSatus.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 663);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(704, 136);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 35);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(587, 136);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 35);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEmpDicNote
            // 
            this.lblEmpDicNote.AutoSize = true;
            this.lblEmpDicNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDicNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmpDicNote.Location = new System.Drawing.Point(6, 106);
            this.lblEmpDicNote.Name = "lblEmpDicNote";
            this.lblEmpDicNote.Size = new System.Drawing.Size(569, 25);
            this.lblEmpDicNote.TabIndex = 54;
            this.lblEmpDicNote.Text = "Manage current staff , update records, and handle etorements.";
            this.lblEmpDicNote.Click += new System.EventHandler(this.lblEmpDicNote_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(488, 136);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 35);
            this.btnEdit.TabIndex = 62;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // pnlAdd1
            // 
            this.pnlAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd1.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd1.Name = "pnlAdd1";
            this.pnlAdd1.Size = new System.Drawing.Size(840, 784);
            this.pnlAdd1.TabIndex = 63;
            // 
            // EmployeesForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAdd1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvMngEmp);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblEmpDictory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEmpDicNote);
            this.Name = "EmployeesForm2";
            this.Size = new System.Drawing.Size(840, 784);
            this.Load += new System.EventHandler(this.EmployeesForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMngEmp;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmpDictory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.ComboBox cmbSatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmpDicNote;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlAdd1;
    }
}
