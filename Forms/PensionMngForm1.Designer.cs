namespace Govt.BDPension.Forms
{
    partial class PensionMngForm1
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
            this.lblRole = new System.Windows.Forms.Label();
            this.btnPenUserRole = new System.Windows.Forms.Button();
            this.btnPenManager = new System.Windows.Forms.Button();
            this.btnPenAdmin = new System.Windows.Forms.Button();
            this.lblPensionAdminis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(358, 678);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 49;
            this.lblRole.Text = "Role";
            // 
            // btnPenUserRole
            // 
            this.btnPenUserRole.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenUserRole.Location = new System.Drawing.Point(285, 411);
            this.btnPenUserRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPenUserRole.Name = "btnPenUserRole";
            this.btnPenUserRole.Size = new System.Drawing.Size(313, 52);
            this.btnPenUserRole.TabIndex = 46;
            this.btnPenUserRole.Text = "User and Role Managment";
            this.btnPenUserRole.UseVisualStyleBackColor = true;
            // 
            // btnPenManager
            // 
            this.btnPenManager.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenManager.Location = new System.Drawing.Point(285, 336);
            this.btnPenManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPenManager.Name = "btnPenManager";
            this.btnPenManager.Size = new System.Drawing.Size(313, 52);
            this.btnPenManager.TabIndex = 45;
            this.btnPenManager.Text = "Pension Manager";
            this.btnPenManager.UseVisualStyleBackColor = true;
            this.btnPenManager.Click += new System.EventHandler(this.btnPenManager_Click);
            // 
            // btnPenAdmin
            // 
            this.btnPenAdmin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenAdmin.Location = new System.Drawing.Point(285, 261);
            this.btnPenAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPenAdmin.Name = "btnPenAdmin";
            this.btnPenAdmin.Size = new System.Drawing.Size(313, 52);
            this.btnPenAdmin.TabIndex = 44;
            this.btnPenAdmin.Text = "Pension Admin";
            this.btnPenAdmin.UseVisualStyleBackColor = true;
            this.btnPenAdmin.Click += new System.EventHandler(this.btnPenAdmin_Click);
            // 
            // lblPensionAdminis
            // 
            this.lblPensionAdminis.AutoSize = true;
            this.lblPensionAdminis.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionAdminis.Location = new System.Drawing.Point(10, 63);
            this.lblPensionAdminis.Name = "lblPensionAdminis";
            this.lblPensionAdminis.Size = new System.Drawing.Size(376, 38);
            this.lblPensionAdminis.TabIndex = 43;
            this.lblPensionAdminis.Text = "Pension Administration";
            // 
            // PensionMngForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnPenUserRole);
            this.Controls.Add(this.btnPenManager);
            this.Controls.Add(this.btnPenAdmin);
            this.Controls.Add(this.lblPensionAdminis);
            this.Name = "PensionMngForm1";
            this.Size = new System.Drawing.Size(840, 784);
            this.Load += new System.EventHandler(this.PensionMngForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnPenUserRole;
        private System.Windows.Forms.Button btnPenManager;
        private System.Windows.Forms.Button btnPenAdmin;
        private System.Windows.Forms.Label lblPensionAdminis;
    }
}
