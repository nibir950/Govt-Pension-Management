namespace Govt.BDPension.Forms
{
    partial class ManMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManMenuForm));
            this.btnRetireMgmt = new System.Windows.Forms.Button();
            this.btnPensionCal = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lblPensionAdmin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetireMgmt
            // 
            this.btnRetireMgmt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetireMgmt.Location = new System.Drawing.Point(10, 369);
            this.btnRetireMgmt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetireMgmt.Name = "btnRetireMgmt";
            this.btnRetireMgmt.Size = new System.Drawing.Size(269, 54);
            this.btnRetireMgmt.TabIndex = 16;
            this.btnRetireMgmt.Text = "Retirement Managment";
            this.btnRetireMgmt.UseVisualStyleBackColor = true;
            this.btnRetireMgmt.Click += new System.EventHandler(this.btnRetireMgmt_Click);
            // 
            // btnPensionCal
            // 
            this.btnPensionCal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPensionCal.Location = new System.Drawing.Point(13, 271);
            this.btnPensionCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPensionCal.Name = "btnPensionCal";
            this.btnPensionCal.Size = new System.Drawing.Size(269, 54);
            this.btnPensionCal.TabIndex = 15;
            this.btnPensionCal.Text = "Pension Calculator";
            this.btnPensionCal.UseVisualStyleBackColor = true;
            this.btnPensionCal.Click += new System.EventHandler(this.btnPensionCal_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(176, 650);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(24, 178);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(269, 54);
            this.btnEmployees.TabIndex = 11;
            this.btnEmployees.Text = "Employess";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // lblPensionAdmin
            // 
            this.lblPensionAdmin.AutoSize = true;
            this.lblPensionAdmin.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionAdmin.Location = new System.Drawing.Point(3, 7);
            this.lblPensionAdmin.Name = "lblPensionAdmin";
            this.lblPensionAdmin.Size = new System.Drawing.Size(279, 38);
            this.lblPensionAdmin.TabIndex = 9;
            this.lblPensionAdmin.Text = "Pension Manager";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(118, 604);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 42;
            this.lblRole.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(312, 784);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 44;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblPensionAdmin);
            this.pnlLeft.Controls.Add(this.btnEmployees);
            this.pnlLeft.Controls.Add(this.lblRole);
            this.pnlLeft.Controls.Add(this.btnBack);
            this.pnlLeft.Controls.Add(this.btnRetireMgmt);
            this.pnlLeft.Controls.Add(this.btnPensionCal);
            this.pnlLeft.Location = new System.Drawing.Point(2, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(312, 784);
            this.pnlLeft.TabIndex = 45;
            // 
            // pnlRight
            // 
            this.pnlRight.Location = new System.Drawing.Point(840, 784);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(200, 100);
            this.pnlRight.TabIndex = 46;
            // 
            // panelRight
            // 
            this.panelRight.Location = new System.Drawing.Point(320, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(840, 784);
            this.panelRight.TabIndex = 47;
            // 
            // ManMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 782);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManMenuForm";
            this.Load += new System.EventHandler(this.ManMenuForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetireMgmt;
        private System.Windows.Forms.Button btnPensionCal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lblPensionAdmin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panelRight;
    }
}