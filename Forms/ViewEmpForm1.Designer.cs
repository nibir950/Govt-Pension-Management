namespace Govt.BDPension.Forms
{
    partial class ViewEmpForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmpForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbSatus = new System.Windows.Forms.ComboBox();
            this.dgvViewEmp = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblEmpDictory = new System.Windows.Forms.Label();
            this.lblEmpDicNote = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmp)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            this.SuspendLayout();
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
            // dgvViewEmp
            // 
            this.dgvViewEmp.AllowUserToAddRows = false;
            this.dgvViewEmp.AllowUserToDeleteRows = false;
            this.dgvViewEmp.AllowUserToResizeColumns = false;
            this.dgvViewEmp.AllowUserToResizeRows = false;
            this.dgvViewEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewEmp.Location = new System.Drawing.Point(3, 211);
            this.dgvViewEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvViewEmp.Name = "dgvViewEmp";
            this.dgvViewEmp.ReadOnly = true;
            this.dgvViewEmp.RowHeadersWidth = 51;
            this.dgvViewEmp.RowTemplate.Height = 24;
            this.dgvViewEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewEmp.Size = new System.Drawing.Size(827, 400);
            this.dgvViewEmp.TabIndex = 71;
            this.dgvViewEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewEmp_CellContentClick);
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
            // lblEmpDictory
            // 
            this.lblEmpDictory.AutoSize = true;
            this.lblEmpDictory.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDictory.Location = new System.Drawing.Point(13, 0);
            this.lblEmpDictory.Name = "lblEmpDictory";
            this.lblEmpDictory.Size = new System.Drawing.Size(255, 38);
            this.lblEmpDictory.TabIndex = 63;
            this.lblEmpDictory.Text = "View Employee ";
            // 
            // lblEmpDicNote
            // 
            this.lblEmpDicNote.AutoSize = true;
            this.lblEmpDicNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDicNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmpDicNote.Location = new System.Drawing.Point(-1, 62);
            this.lblEmpDicNote.Name = "lblEmpDicNote";
            this.lblEmpDicNote.Size = new System.Drawing.Size(569, 25);
            this.lblEmpDicNote.TabIndex = 64;
            this.lblEmpDicNote.Text = "Manage current staff , update records, and handle etorements.";
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
            this.pnlSearchBar.Location = new System.Drawing.Point(3, 135);
            this.pnlSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(840, 68);
            this.pnlSearchBar.TabIndex = 65;
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
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(374, 635);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 70;
            this.lblRole.Text = "Role";
            // 
            // ViewEmpForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvViewEmp);
            this.Controls.Add(this.lblEmpDictory);
            this.Controls.Add(this.lblEmpDicNote);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.lblRole);
            this.Name = "ViewEmpForm1";
            this.Size = new System.Drawing.Size(840, 784);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmp)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbSatus;
        private System.Windows.Forms.DataGridView dgvViewEmp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblEmpDictory;
        private System.Windows.Forms.Label lblEmpDicNote;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblRole;
    }
}
