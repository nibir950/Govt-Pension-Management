namespace Govt.BDPension.Forms
{
    partial class UserRoleForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoleForm1));
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.lblRoledecision = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUserAcessNote = new System.Windows.Forms.Label();
            this.btnDlt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUserAccess = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUserControl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserControl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(550, 1068);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 60;
            this.lblRole.Text = "Role";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1150, 1060);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 59;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(280, 12);
            this.picSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(51, 41);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 21;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // lblRoledecision
            // 
            this.lblRoledecision.AutoSize = true;
            this.lblRoledecision.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoledecision.Location = new System.Drawing.Point(337, 28);
            this.lblRoledecision.Name = "lblRoledecision";
            this.lblRoledecision.Size = new System.Drawing.Size(52, 25);
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
            this.cmbDept.Location = new System.Drawing.Point(386, 22);
            this.cmbDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 31);
            this.cmbDept.TabIndex = 12;
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.Location = new System.Drawing.Point(3, 19);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(127, 25);
            this.lblSearchEmployee.TabIndex = 11;
            this.lblSearchEmployee.Text = "Employee ID";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(127, 16);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(147, 32);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(40, 1060);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblUserAcessNote
            // 
            this.lblUserAcessNote.AutoSize = true;
            this.lblUserAcessNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAcessNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserAcessNote.Location = new System.Drawing.Point(20, 59);
            this.lblUserAcessNote.Name = "lblUserAcessNote";
            this.lblUserAcessNote.Size = new System.Drawing.Size(716, 25);
            this.lblUserAcessNote.TabIndex = 55;
            this.lblUserAcessNote.Text = "Manage system access, user accounts, and permissions for the penssion portal.";
            // 
            // btnDlt
            // 
            this.btnDlt.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.Location = new System.Drawing.Point(612, 22);
            this.btnDlt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(100, 35);
            this.btnDlt.TabIndex = 49;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(714, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 35);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.pnlSearchBar.Location = new System.Drawing.Point(25, 110);
            this.pnlSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(812, 68);
            this.pnlSearchBar.TabIndex = 56;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(513, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 35);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblUserAccess
            // 
            this.lblUserAccess.AutoSize = true;
            this.lblUserAccess.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAccess.Location = new System.Drawing.Point(18, 21);
            this.lblUserAccess.Name = "lblUserAccess";
            this.lblUserAccess.Size = new System.Drawing.Size(315, 38);
            this.lblUserAccess.TabIndex = 54;
            this.lblUserAccess.Text = "User Access Control";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(685, 720);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 61;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvUserControl
            // 
            this.dgvUserControl.AllowUserToAddRows = false;
            this.dgvUserControl.AllowUserToDeleteRows = false;
            this.dgvUserControl.AllowUserToResizeColumns = false;
            this.dgvUserControl.AllowUserToResizeRows = false;
            this.dgvUserControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvUserControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserControl.Location = new System.Drawing.Point(25, 194);
            this.dgvUserControl.Name = "dgvUserControl";
            this.dgvUserControl.RowHeadersWidth = 62;
            this.dgvUserControl.RowTemplate.Height = 28;
            this.dgvUserControl.Size = new System.Drawing.Size(805, 442);
            this.dgvUserControl.TabIndex = 62;
            this.dgvUserControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserControl_CellContentClick);
            this.dgvUserControl.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserControl_CellContentClick);
            this.dgvUserControl.DoubleClick += new System.EventHandler(this.dgvUserControl_doubleClick);
            // 
            // UserRoleForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUserControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUserAcessNote);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.lblUserAccess);
            this.Name = "UserRoleForm1";
            this.Size = new System.Drawing.Size(840, 784);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblRoledecision;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUserAcessNote;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblUserAccess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUserControl;
    }
}
