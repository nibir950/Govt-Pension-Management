namespace Govt.BDPension.Forms
{
    partial class DashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.lblDashboard = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.grpNewRetires = new System.Windows.Forms.GroupBox();
            this.lblNewRetire = new System.Windows.Forms.Label();
            this.grpPendingApprove = new System.Windows.Forms.GroupBox();
            this.lblPendingApp = new System.Windows.Forms.Label();
            this.grpTotalPensioners = new System.Windows.Forms.GroupBox();
            this.lblTotalPensioner = new System.Windows.Forms.Label();
            this.grpTotalPayout = new System.Windows.Forms.GroupBox();
            this.lblTotalMonthPay = new System.Windows.Forms.Label();
            this.grpRetiredEmp = new System.Windows.Forms.GroupBox();
            this.lblRetireEmp = new System.Windows.Forms.Label();
            this.grpActiveEmp = new System.Windows.Forms.GroupBox();
            this.lblActiveEmp = new System.Windows.Forms.Label();
            this.grpTotalEmp = new System.Windows.Forms.GroupBox();
            this.lblTotalEmp = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.grpNewRetires.SuspendLayout();
            this.grpPendingApprove.SuspendLayout();
            this.grpTotalPensioners.SuspendLayout();
            this.grpTotalPayout.SuspendLayout();
            this.grpRetiredEmp.SuspendLayout();
            this.grpActiveEmp.SuspendLayout();
            this.grpTotalEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(29, 42);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(286, 33);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard Overview";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(918, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(144, 33);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.Location = new System.Drawing.Point(747, 50);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(152, 20);
            this.lblSearchEmployee.TabIndex = 9;
            this.lblSearchEmployee.Text = "Search employee ID";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1051, 657);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 34);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 657);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(1059, 42);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(45, 33);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 21;
            this.picSearch.TabStop = false;
            // 
            // grpNewRetires
            // 
            this.grpNewRetires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpNewRetires.Controls.Add(this.lblNewRetire);
            this.grpNewRetires.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewRetires.Location = new System.Drawing.Point(626, 374);
            this.grpNewRetires.Name = "grpNewRetires";
            this.grpNewRetires.Size = new System.Drawing.Size(200, 142);
            this.grpNewRetires.TabIndex = 40;
            this.grpNewRetires.TabStop = false;
            this.grpNewRetires.Text = "New Retires";
            // 
            // lblNewRetire
            // 
            this.lblNewRetire.AutoSize = true;
            this.lblNewRetire.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRetire.Location = new System.Drawing.Point(68, 52);
            this.lblNewRetire.Name = "lblNewRetire";
            this.lblNewRetire.Size = new System.Drawing.Size(57, 38);
            this.lblNewRetire.TabIndex = 18;
            this.lblNewRetire.Text = "14";
            // 
            // grpPendingApprove
            // 
            this.grpPendingApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpPendingApprove.Controls.Add(this.lblPendingApp);
            this.grpPendingApprove.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPendingApprove.Location = new System.Drawing.Point(352, 374);
            this.grpPendingApprove.Name = "grpPendingApprove";
            this.grpPendingApprove.Size = new System.Drawing.Size(200, 142);
            this.grpPendingApprove.TabIndex = 39;
            this.grpPendingApprove.TabStop = false;
            this.grpPendingApprove.Text = "Pending Approvals";
            // 
            // lblPendingApp
            // 
            this.lblPendingApp.AutoSize = true;
            this.lblPendingApp.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingApp.Location = new System.Drawing.Point(68, 52);
            this.lblPendingApp.Name = "lblPendingApp";
            this.lblPendingApp.Size = new System.Drawing.Size(57, 38);
            this.lblPendingApp.TabIndex = 18;
            this.lblPendingApp.Text = "25";
            // 
            // grpTotalPensioners
            // 
            this.grpTotalPensioners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpTotalPensioners.Controls.Add(this.lblTotalPensioner);
            this.grpTotalPensioners.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalPensioners.Location = new System.Drawing.Point(76, 374);
            this.grpTotalPensioners.Name = "grpTotalPensioners";
            this.grpTotalPensioners.Size = new System.Drawing.Size(200, 142);
            this.grpTotalPensioners.TabIndex = 38;
            this.grpTotalPensioners.TabStop = false;
            this.grpTotalPensioners.Text = "Total Pensioners";
            // 
            // lblTotalPensioner
            // 
            this.lblTotalPensioner.AutoSize = true;
            this.lblTotalPensioner.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPensioner.Location = new System.Drawing.Point(53, 52);
            this.lblTotalPensioner.Name = "lblTotalPensioner";
            this.lblTotalPensioner.Size = new System.Drawing.Size(77, 38);
            this.lblTotalPensioner.TabIndex = 18;
            this.lblTotalPensioner.Text = "149";
            // 
            // grpTotalPayout
            // 
            this.grpTotalPayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpTotalPayout.Controls.Add(this.lblTotalMonthPay);
            this.grpTotalPayout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalPayout.Location = new System.Drawing.Point(906, 186);
            this.grpTotalPayout.Name = "grpTotalPayout";
            this.grpTotalPayout.Size = new System.Drawing.Size(200, 142);
            this.grpTotalPayout.TabIndex = 37;
            this.grpTotalPayout.TabStop = false;
            this.grpTotalPayout.Text = "Total Monthly Payouts";
            // 
            // lblTotalMonthPay
            // 
            this.lblTotalMonthPay.AutoSize = true;
            this.lblTotalMonthPay.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMonthPay.Location = new System.Drawing.Point(26, 52);
            this.lblTotalMonthPay.Name = "lblTotalMonthPay";
            this.lblTotalMonthPay.Size = new System.Drawing.Size(145, 38);
            this.lblTotalMonthPay.TabIndex = 17;
            this.lblTotalMonthPay.Text = "1445.00";
            // 
            // grpRetiredEmp
            // 
            this.grpRetiredEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpRetiredEmp.Controls.Add(this.lblRetireEmp);
            this.grpRetiredEmp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRetiredEmp.Location = new System.Drawing.Point(626, 186);
            this.grpRetiredEmp.Name = "grpRetiredEmp";
            this.grpRetiredEmp.Size = new System.Drawing.Size(200, 142);
            this.grpRetiredEmp.TabIndex = 36;
            this.grpRetiredEmp.TabStop = false;
            this.grpRetiredEmp.Text = "Retired Employees";
            // 
            // lblRetireEmp
            // 
            this.lblRetireEmp.AutoSize = true;
            this.lblRetireEmp.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetireEmp.Location = new System.Drawing.Point(68, 52);
            this.lblRetireEmp.Name = "lblRetireEmp";
            this.lblRetireEmp.Size = new System.Drawing.Size(57, 38);
            this.lblRetireEmp.TabIndex = 17;
            this.lblRetireEmp.Text = "34";
            // 
            // grpActiveEmp
            // 
            this.grpActiveEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpActiveEmp.Controls.Add(this.lblActiveEmp);
            this.grpActiveEmp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActiveEmp.Location = new System.Drawing.Point(352, 186);
            this.grpActiveEmp.Name = "grpActiveEmp";
            this.grpActiveEmp.Size = new System.Drawing.Size(200, 142);
            this.grpActiveEmp.TabIndex = 35;
            this.grpActiveEmp.TabStop = false;
            this.grpActiveEmp.Text = "Active Employees";
            // 
            // lblActiveEmp
            // 
            this.lblActiveEmp.AutoSize = true;
            this.lblActiveEmp.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveEmp.Location = new System.Drawing.Point(68, 52);
            this.lblActiveEmp.Name = "lblActiveEmp";
            this.lblActiveEmp.Size = new System.Drawing.Size(57, 38);
            this.lblActiveEmp.TabIndex = 17;
            this.lblActiveEmp.Text = "15";
            // 
            // grpTotalEmp
            // 
            this.grpTotalEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpTotalEmp.Controls.Add(this.lblTotalEmp);
            this.grpTotalEmp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalEmp.Location = new System.Drawing.Point(76, 186);
            this.grpTotalEmp.Name = "grpTotalEmp";
            this.grpTotalEmp.Size = new System.Drawing.Size(200, 142);
            this.grpTotalEmp.TabIndex = 34;
            this.grpTotalEmp.TabStop = false;
            this.grpTotalEmp.Text = "Total Employees";
            // 
            // lblTotalEmp
            // 
            this.lblTotalEmp.AutoSize = true;
            this.lblTotalEmp.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmp.Location = new System.Drawing.Point(53, 52);
            this.lblTotalEmp.Name = "lblTotalEmp";
            this.lblTotalEmp.Size = new System.Drawing.Size(77, 38);
            this.lblTotalEmp.TabIndex = 17;
            this.lblTotalEmp.Text = "144";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(504, 657);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 21);
            this.lblRole.TabIndex = 41;
            this.lblRole.Text = "Role";
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.grpNewRetires);
            this.Controls.Add(this.grpPendingApprove);
            this.Controls.Add(this.grpTotalPensioners);
            this.Controls.Add(this.grpTotalPayout);
            this.Controls.Add(this.grpRetiredEmp);
            this.Controls.Add(this.grpActiveEmp);
            this.Controls.Add(this.grpTotalEmp);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblSearchEmployee);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.grpNewRetires.ResumeLayout(false);
            this.grpNewRetires.PerformLayout();
            this.grpPendingApprove.ResumeLayout(false);
            this.grpPendingApprove.PerformLayout();
            this.grpTotalPensioners.ResumeLayout(false);
            this.grpTotalPensioners.PerformLayout();
            this.grpTotalPayout.ResumeLayout(false);
            this.grpTotalPayout.PerformLayout();
            this.grpRetiredEmp.ResumeLayout(false);
            this.grpRetiredEmp.PerformLayout();
            this.grpActiveEmp.ResumeLayout(false);
            this.grpActiveEmp.PerformLayout();
            this.grpTotalEmp.ResumeLayout(false);
            this.grpTotalEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.GroupBox grpNewRetires;
        private System.Windows.Forms.Label lblNewRetire;
        private System.Windows.Forms.GroupBox grpPendingApprove;
        private System.Windows.Forms.Label lblPendingApp;
        private System.Windows.Forms.GroupBox grpTotalPensioners;
        private System.Windows.Forms.Label lblTotalPensioner;
        private System.Windows.Forms.GroupBox grpTotalPayout;
        private System.Windows.Forms.Label lblTotalMonthPay;
        private System.Windows.Forms.GroupBox grpRetiredEmp;
        private System.Windows.Forms.Label lblRetireEmp;
        private System.Windows.Forms.GroupBox grpActiveEmp;
        private System.Windows.Forms.Label lblActiveEmp;
        private System.Windows.Forms.GroupBox grpTotalEmp;
        private System.Windows.Forms.Label lblTotalEmp;
        private System.Windows.Forms.Label lblRole;
    }
}