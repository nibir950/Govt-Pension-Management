namespace Govt.BDPension.Forms
{
    partial class RetirementMgmt1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetirementMgmt1));
            this.lblRole = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbSatus = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.btnArchived = new System.Windows.Forms.Button();
            this.lblRetireMgmtNote = new System.Windows.Forms.Label();
            this.lblRetirementMgmt = new System.Windows.Forms.Label();
            this.pnlChoiceBar = new System.Windows.Forms.Panel();
            this.btnRetireThisYear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRtrMng = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            this.pnlChoiceBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRtrMng)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(667, 799);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 53;
            this.lblRole.Text = "Role";
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(313, 12);
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
            this.lblStatus.Location = new System.Drawing.Point(610, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 25);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "All Status";
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
            this.cmbSatus.Location = new System.Drawing.Point(713, 25);
            this.cmbSatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSatus.Name = "cmbSatus";
            this.cmbSatus.Size = new System.Drawing.Size(80, 31);
            this.cmbSatus.TabIndex = 14;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(370, 24);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(150, 25);
            this.lblDept.TabIndex = 13;
            this.lblDept.Text = "All Department";
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
            this.cmbDept.Location = new System.Drawing.Point(520, 22);
            this.cmbDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(84, 31);
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
            this.richTextBox1.Location = new System.Drawing.Point(134, 12);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 34);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            this.pnlSearchBar.Location = new System.Drawing.Point(3, 133);
            this.pnlSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(824, 60);
            this.pnlSearchBar.TabIndex = 51;
            // 
            // btnArchived
            // 
            this.btnArchived.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.Location = new System.Drawing.Point(520, 16);
            this.btnArchived.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(231, 35);
            this.btnArchived.TabIndex = 2;
            this.btnArchived.Text = "Archived";
            this.btnArchived.UseVisualStyleBackColor = true;
            this.btnArchived.Click += new System.EventHandler(this.btnArchived_Click);
            // 
            // lblRetireMgmtNote
            // 
            this.lblRetireMgmtNote.AutoSize = true;
            this.lblRetireMgmtNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetireMgmtNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRetireMgmtNote.Location = new System.Drawing.Point(82, 16);
            this.lblRetireMgmtNote.Name = "lblRetireMgmtNote";
            this.lblRetireMgmtNote.Size = new System.Drawing.Size(600, 25);
            this.lblRetireMgmtNote.TabIndex = 44;
            this.lblRetireMgmtNote.Text = "Manage upcoming employee retirements and pension processing.";
            // 
            // lblRetirementMgmt
            // 
            this.lblRetirementMgmt.AutoSize = true;
            this.lblRetirementMgmt.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirementMgmt.Location = new System.Drawing.Point(152, -56);
            this.lblRetirementMgmt.Name = "lblRetirementMgmt";
            this.lblRetirementMgmt.Size = new System.Drawing.Size(377, 38);
            this.lblRetirementMgmt.TabIndex = 43;
            this.lblRetirementMgmt.Text = "Retirement Managment";
            // 
            // pnlChoiceBar
            // 
            this.pnlChoiceBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlChoiceBar.Controls.Add(this.btnArchived);
            this.pnlChoiceBar.Controls.Add(this.btnRetireThisYear);
            this.pnlChoiceBar.Location = new System.Drawing.Point(3, 57);
            this.pnlChoiceBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlChoiceBar.Name = "pnlChoiceBar";
            this.pnlChoiceBar.Size = new System.Drawing.Size(824, 68);
            this.pnlChoiceBar.TabIndex = 50;
            this.pnlChoiceBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChoiceBar_Paint);
            // 
            // btnRetireThisYear
            // 
            this.btnRetireThisYear.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetireThisYear.Location = new System.Drawing.Point(17, 16);
            this.btnRetireThisYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetireThisYear.Name = "btnRetireThisYear";
            this.btnRetireThisYear.Size = new System.Drawing.Size(231, 35);
            this.btnRetireThisYear.TabIndex = 0;
            this.btnRetireThisYear.Text = "Retiring This year";
            this.btnRetireThisYear.UseVisualStyleBackColor = true;
            this.btnRetireThisYear.Click += new System.EventHandler(this.btnRetireThisYear_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(138, 799);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1308, 799);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 49;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(675, 723);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 54;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRtrMng
            // 
            this.dgvRtrMng.AllowUserToAddRows = false;
            this.dgvRtrMng.AllowUserToDeleteRows = false;
            this.dgvRtrMng.AllowUserToResizeColumns = false;
            this.dgvRtrMng.AllowUserToResizeRows = false;
            this.dgvRtrMng.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvRtrMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRtrMng.GridColor = System.Drawing.Color.Red;
            this.dgvRtrMng.Location = new System.Drawing.Point(3, 196);
            this.dgvRtrMng.Name = "dgvRtrMng";
            this.dgvRtrMng.ReadOnly = true;
            this.dgvRtrMng.RowHeadersWidth = 62;
            this.dgvRtrMng.RowTemplate.Height = 28;
            this.dgvRtrMng.Size = new System.Drawing.Size(824, 471);
            this.dgvRtrMng.TabIndex = 55;
            this.dgvRtrMng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRtrMng_CellContentClick);
            // 
            // RetirementMgmt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRtrMng);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.lblRetireMgmtNote);
            this.Controls.Add(this.lblRetirementMgmt);
            this.Controls.Add(this.pnlChoiceBar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Name = "RetirementMgmt1";
            this.Size = new System.Drawing.Size(840, 784);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            this.pnlChoiceBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRtrMng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbSatus;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Button btnArchived;
        private System.Windows.Forms.Label lblRetireMgmtNote;
        private System.Windows.Forms.Label lblRetirementMgmt;
        private System.Windows.Forms.Panel pnlChoiceBar;
        private System.Windows.Forms.Button btnRetireThisYear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRtrMng;
    }
}
