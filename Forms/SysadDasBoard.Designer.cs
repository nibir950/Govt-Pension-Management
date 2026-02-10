namespace Govt.BDPension.Forms
{
    partial class SysadDasBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysadDasBoard));
            this.btnUserControl = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnPensionMng = new System.Windows.Forms.Button();
            this.lblSystemAdmin = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserControl
            // 
            this.btnUserControl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserControl.Location = new System.Drawing.Point(3, 271);
            this.btnUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserControl.Name = "btnUserControl";
            this.btnUserControl.Size = new System.Drawing.Size(309, 54);
            this.btnUserControl.TabIndex = 22;
            this.btnUserControl.Text = "User Access Control";
            this.btnUserControl.UseVisualStyleBackColor = true;
            this.btnUserControl.Click += new System.EventHandler(this.btnUserControl_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(176, 642);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHR
            // 
            this.btnHR.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHR.Location = new System.Drawing.Point(3, 209);
            this.btnHR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(309, 54);
            this.btnHR.TabIndex = 19;
            this.btnHR.Text = "Human Resource Management";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnPensionMng
            // 
            this.btnPensionMng.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPensionMng.Location = new System.Drawing.Point(-2, 147);
            this.btnPensionMng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPensionMng.Name = "btnPensionMng";
            this.btnPensionMng.Size = new System.Drawing.Size(314, 54);
            this.btnPensionMng.TabIndex = 18;
            this.btnPensionMng.Text = "Pension Administration";
            this.btnPensionMng.UseVisualStyleBackColor = true;
            this.btnPensionMng.Click += new System.EventHandler(this.btnPensionMng_Click);
            // 
            // lblSystemAdmin
            // 
            this.lblSystemAdmin.AutoSize = true;
            this.lblSystemAdmin.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemAdmin.Location = new System.Drawing.Point(3, 0);
            this.lblSystemAdmin.Name = "lblSystemAdmin";
            this.lblSystemAdmin.Size = new System.Drawing.Size(232, 38);
            this.lblSystemAdmin.TabIndex = 17;
            this.lblSystemAdmin.Text = "System Admin";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(614, 747);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 42;
            this.lblRole.Text = "Role";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnPensionMng);
            this.panelLeft.Controls.Add(this.btnHR);
            this.panelLeft.Controls.Add(this.lblSystemAdmin);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnUserControl);
            this.panelLeft.Location = new System.Drawing.Point(1, -3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(312, 784);
            this.panelLeft.TabIndex = 43;
            // 
            // panelRight
            // 
            this.panelRight.Location = new System.Drawing.Point(316, -3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(840, 784);
            this.panelRight.TabIndex = 44;
            // 
            // SysadDasBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 782);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblRole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SysadDasBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysadDasBoard";
            this.Load += new System.EventHandler(this.SysadDasBoard_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUserControl;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnPensionMng;
        private System.Windows.Forms.Label lblSystemAdmin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
    }
}