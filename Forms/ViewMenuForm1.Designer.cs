namespace Govt.BDPension.Forms
{
    partial class ViewMenuForm1
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lblViewer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPensionCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(677, 640);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(247, 265);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(269, 54);
            this.btnEmployees.TabIndex = 31;
            this.btnEmployees.Text = "Employess";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // lblViewer
            // 
            this.lblViewer.AutoSize = true;
            this.lblViewer.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewer.Location = new System.Drawing.Point(76, 27);
            this.lblViewer.Name = "lblViewer";
            this.lblViewer.Size = new System.Drawing.Size(124, 38);
            this.lblViewer.TabIndex = 29;
            this.lblViewer.Text = "Viewer";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(441, 544);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 26);
            this.lblRole.TabIndex = 35;
            this.lblRole.Text = "Role";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 640);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnPensionCal
            // 
            this.btnPensionCal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPensionCal.Location = new System.Drawing.Point(247, 374);
            this.btnPensionCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPensionCal.Name = "btnPensionCal";
            this.btnPensionCal.Size = new System.Drawing.Size(269, 54);
            this.btnPensionCal.TabIndex = 33;
            this.btnPensionCal.Text = "Pension Calculator";
            this.btnPensionCal.UseVisualStyleBackColor = true;
            // 
            // ViewMenuForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.lblViewer);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPensionCal);
            this.Name = "ViewMenuForm1";
            this.Size = new System.Drawing.Size(840, 784);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lblViewer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPensionCal;
    }
}
