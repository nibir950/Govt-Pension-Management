namespace Govt.BDPension.Forms
{
    partial class PensionMngForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PensionMngForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPenManager = new System.Windows.Forms.Button();
            this.btnPenAdmin = new System.Windows.Forms.Button();
            this.lblPensionAdminis = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(765, 641);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPenManager
            // 
            this.btnPenManager.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenManager.Location = new System.Drawing.Point(299, 299);
            this.btnPenManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPenManager.Name = "btnPenManager";
            this.btnPenManager.Size = new System.Drawing.Size(317, 54);
            this.btnPenManager.TabIndex = 26;
            this.btnPenManager.Text = "Pension Manager";
            this.btnPenManager.UseVisualStyleBackColor = true;
            this.btnPenManager.Click += new System.EventHandler(this.btnPenManager_Click);
            // 
            // btnPenAdmin
            // 
            this.btnPenAdmin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenAdmin.Location = new System.Drawing.Point(299, 224);
            this.btnPenAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPenAdmin.Name = "btnPenAdmin";
            this.btnPenAdmin.Size = new System.Drawing.Size(317, 54);
            this.btnPenAdmin.TabIndex = 25;
            this.btnPenAdmin.Text = "Pension Admin";
            this.btnPenAdmin.UseVisualStyleBackColor = true;
            this.btnPenAdmin.Click += new System.EventHandler(this.btnPenAdmin_Click);
            // 
            // lblPensionAdminis
            // 
            this.lblPensionAdminis.AutoSize = true;
            this.lblPensionAdminis.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionAdminis.Location = new System.Drawing.Point(24, 26);
            this.lblPensionAdminis.Name = "lblPensionAdminis";
            this.lblPensionAdminis.Size = new System.Drawing.Size(376, 38);
            this.lblPensionAdminis.TabIndex = 24;
            this.lblPensionAdminis.Text = "Pension Administration";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(14, 641);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(372, 641);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 42;
            this.lblRole.Text = "Role";
            // 
            // PensionMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 711);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPenManager);
            this.Controls.Add(this.btnPenAdmin);
            this.Controls.Add(this.lblPensionAdminis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PensionMngForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PensionMngForm";
            this.Load += new System.EventHandler(this.PensionMngForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPenManager;
        private System.Windows.Forms.Button btnPenAdmin;
        private System.Windows.Forms.Label lblPensionAdminis;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRole;
    }
}