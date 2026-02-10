namespace Govt.BDPension.Forms
{
    partial class ViewMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenuForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lblViewer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPensionCal = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(154, 638);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 42);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(18, 133);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(269, 54);
            this.btnEmployees.TabIndex = 21;
            this.btnEmployees.Text = "Employess";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // lblViewer
            // 
            this.lblViewer.AutoSize = true;
            this.lblViewer.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewer.Location = new System.Drawing.Point(3, 6);
            this.lblViewer.Name = "lblViewer";
            this.lblViewer.Size = new System.Drawing.Size(124, 38);
            this.lblViewer.TabIndex = 19;
            this.lblViewer.Text = "Viewer";
            this.lblViewer.Click += new System.EventHandler(this.lblViewer_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(100, 566);
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
            this.btnBack.Location = new System.Drawing.Point(18, 641);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPensionCal
            // 
            this.btnPensionCal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPensionCal.Location = new System.Drawing.Point(18, 234);
            this.btnPensionCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPensionCal.Name = "btnPensionCal";
            this.btnPensionCal.Size = new System.Drawing.Size(269, 54);
            this.btnPensionCal.TabIndex = 25;
            this.btnPensionCal.Text = "Pension Calculator";
            this.btnPensionCal.UseVisualStyleBackColor = true;
            this.btnPensionCal.Click += new System.EventHandler(this.btnPensionCal_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblViewer);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.btnEmployees);
            this.pnlLeft.Controls.Add(this.lblRole);
            this.pnlLeft.Controls.Add(this.btnPensionCal);
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(312, 784);
            this.pnlLeft.TabIndex = 29;
            // 
            // pnlRight
            // 
            this.pnlRight.Location = new System.Drawing.Point(318, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(840, 784);
            this.pnlRight.TabIndex = 30;
            // 
            // ViewMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 782);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMenuForm";
            this.Load += new System.EventHandler(this.ViewMenuForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lblViewer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPensionCal;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
    }
}