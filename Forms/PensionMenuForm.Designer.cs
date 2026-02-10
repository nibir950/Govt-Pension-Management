namespace Govt.BDPension.Forms
{
    partial class PensionMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PensionMenuForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.button1Back = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lblPensionAdmin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRetireMgmt = new System.Windows.Forms.Button();
            this.btnPensionCal = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.button1Back);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.btnEmployees);
            this.pnlLeft.Controls.Add(this.lblPensionAdmin);
            this.pnlLeft.Controls.Add(this.lblRole);
            this.pnlLeft.Controls.Add(this.btnBack);
            this.pnlLeft.Controls.Add(this.btnRetireMgmt);
            this.pnlLeft.Controls.Add(this.btnPensionCal);
            this.pnlLeft.Location = new System.Drawing.Point(1, -3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(312, 784);
            this.pnlLeft.TabIndex = 0;
            // 
            // button1Back
            // 
            this.button1Back.BackColor = System.Drawing.Color.Yellow;
            this.button1Back.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Back.Location = new System.Drawing.Point(160, 659);
            this.button1Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1Back.Name = "button1Back";
            this.button1Back.Size = new System.Drawing.Size(133, 42);
            this.button1Back.TabIndex = 46;
            this.button1Back.Text = "Back";
            this.button1Back.UseVisualStyleBackColor = false;
            this.button1Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(460, 679);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(0, 168);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(309, 54);
            this.btnEmployees.TabIndex = 21;
            this.btnEmployees.Text = "Employess";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // lblPensionAdmin
            // 
            this.lblPensionAdmin.AutoSize = true;
            this.lblPensionAdmin.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionAdmin.Location = new System.Drawing.Point(3, 12);
            this.lblPensionAdmin.Name = "lblPensionAdmin";
            this.lblPensionAdmin.Size = new System.Drawing.Size(246, 38);
            this.lblPensionAdmin.TabIndex = 19;
            this.lblPensionAdmin.Text = "Pension Admin";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(113, 587);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 28;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(-291, 679);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnRetireMgmt
            // 
            this.btnRetireMgmt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetireMgmt.Location = new System.Drawing.Point(3, 283);
            this.btnRetireMgmt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetireMgmt.Name = "btnRetireMgmt";
            this.btnRetireMgmt.Size = new System.Drawing.Size(309, 54);
            this.btnRetireMgmt.TabIndex = 26;
            this.btnRetireMgmt.Text = "Retirement Managment";
            this.btnRetireMgmt.UseVisualStyleBackColor = true;
            this.btnRetireMgmt.Click += new System.EventHandler(this.btnRetireMgmt_Click_1);
            // 
            // btnPensionCal
            // 
            this.btnPensionCal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPensionCal.Location = new System.Drawing.Point(0, 221);
            this.btnPensionCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPensionCal.Name = "btnPensionCal";
            this.btnPensionCal.Size = new System.Drawing.Size(309, 54);
            this.btnPensionCal.TabIndex = 25;
            this.btnPensionCal.Text = "Pension Calculator";
            this.btnPensionCal.UseVisualStyleBackColor = true;
            this.btnPensionCal.Click += new System.EventHandler(this.btnPensionCal_Click_1);
            // 
            // pnlRight
            // 
            this.pnlRight.Location = new System.Drawing.Point(316, -3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(840, 784);
            this.pnlRight.TabIndex = 1;
            // 
            // PensionMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 782);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PensionMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PensionMenuForm";
            this.Load += new System.EventHandler(this.PensionMenuForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lblPensionAdmin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRetireMgmt;
        private System.Windows.Forms.Button btnPensionCal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button button1Back;
    }
}