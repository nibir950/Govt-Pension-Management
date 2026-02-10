namespace Govt.BDPension.Forms
{
    partial class PayoutsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayoutsForm));
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.dtToday = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbSatus = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPayoutsNote = new System.Windows.Forms.Label();
            this.lblPayouts = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlChoiceBar = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblRoleShow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlChoiceBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSearchBar.Controls.Add(this.lblSearchEmployee);
            this.pnlSearchBar.Controls.Add(this.picSearch);
            this.pnlSearchBar.Controls.Add(this.dtToday);
            this.pnlSearchBar.Controls.Add(this.lblStatus);
            this.pnlSearchBar.Controls.Add(this.cmbSatus);
            this.pnlSearchBar.Controls.Add(this.richTextBox1);
            this.pnlSearchBar.Location = new System.Drawing.Point(26, 136);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(1105, 54);
            this.pnlSearchBar.TabIndex = 31;
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.Location = new System.Drawing.Point(3, 17);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(152, 20);
            this.lblSearchEmployee.TabIndex = 11;
            this.lblSearchEmployee.Text = "Search employee ID";
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(390, 9);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(45, 33);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 20;
            this.picSearch.TabStop = false;
            // 
            // dtToday
            // 
            this.dtToday.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToday.Location = new System.Drawing.Point(484, 14);
            this.dtToday.Name = "dtToday";
            this.dtToday.Size = new System.Drawing.Size(299, 27);
            this.dtToday.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(813, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 20);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "All Status";
            // 
            // cmbSatus
            // 
            this.cmbSatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatus.FormattingEnabled = true;
            this.cmbSatus.Items.AddRange(new object[] {
            "1. Paid",
            "2. Pending",
            "3. Failed"});
            this.cmbSatus.Location = new System.Drawing.Point(907, 14);
            this.cmbSatus.Name = "cmbSatus";
            this.cmbSatus.Size = new System.Drawing.Size(180, 28);
            this.cmbSatus.TabIndex = 14;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(182, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 33);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1047, 703);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 34);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(7, 703);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPayoutsNote
            // 
            this.lblPayoutsNote.AutoSize = true;
            this.lblPayoutsNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayoutsNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPayoutsNote.Location = new System.Drawing.Point(22, 91);
            this.lblPayoutsNote.Name = "lblPayoutsNote";
            this.lblPayoutsNote.Size = new System.Drawing.Size(474, 20);
            this.lblPayoutsNote.TabIndex = 23;
            this.lblPayoutsNote.Text = "Review and manage monthly pension disbursements and history.";
            // 
            // lblPayouts
            // 
            this.lblPayouts.AutoSize = true;
            this.lblPayouts.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayouts.Location = new System.Drawing.Point(20, 58);
            this.lblPayouts.Name = "lblPayouts";
            this.lblPayouts.Size = new System.Drawing.Size(224, 33);
            this.lblPayouts.TabIndex = 22;
            this.lblPayouts.Text = "Pension Payouts";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(506, 716);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 21);
            this.lblRole.TabIndex = 42;
            this.lblRole.Text = "Role";
            // 
            // pnlChoiceBar
            // 
            this.pnlChoiceBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlChoiceBar.Controls.Add(this.lblAmount);
            this.pnlChoiceBar.Controls.Add(this.lblState);
            this.pnlChoiceBar.Controls.Add(this.lblRoleShow);
            this.pnlChoiceBar.Controls.Add(this.lblName);
            this.pnlChoiceBar.Controls.Add(this.lblEmpID);
            this.pnlChoiceBar.Location = new System.Drawing.Point(26, 196);
            this.pnlChoiceBar.Name = "pnlChoiceBar";
            this.pnlChoiceBar.Size = new System.Drawing.Size(1105, 54);
            this.pnlChoiceBar.TabIndex = 47;
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
            this.lblRoleShow.Location = new System.Drawing.Point(769, 20);
            this.lblRoleShow.Name = "lblRoleShow";
            this.lblRoleShow.Size = new System.Drawing.Size(45, 17);
            this.lblRoleShow.TabIndex = 3;
            this.lblRoleShow.Text = "ROLE";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(179, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
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
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(507, 20);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 17);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "AMOUNT";
            // 
            // PayoutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 756);
            this.Controls.Add(this.pnlChoiceBar);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPayoutsNote);
            this.Controls.Add(this.lblPayouts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayoutsForm";
            this.Text = "PayoutsForm";
            this.Load += new System.EventHandler(this.PayoutsForm_Load);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlChoiceBar.ResumeLayout(false);
            this.pnlChoiceBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbSatus;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPayoutsNote;
        private System.Windows.Forms.Label lblPayouts;
        private System.Windows.Forms.DateTimePicker dtToday;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlChoiceBar;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblRoleShow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmpID;
    }
}