namespace Govt.BDPension.Forms
{
    partial class ForgotMsgFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotMsgFrom));
            this.pnlForgotMsg = new System.Windows.Forms.Panel();
            this.lblForgotMsg2 = new System.Windows.Forms.Label();
            this.lblForgotMsg = new System.Windows.Forms.Label();
            this.lblfootertext = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlForgotMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForgotMsg
            // 
            this.pnlForgotMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlForgotMsg.Controls.Add(this.lblForgotMsg2);
            this.pnlForgotMsg.Controls.Add(this.lblForgotMsg);
            this.pnlForgotMsg.Location = new System.Drawing.Point(88, 52);
            this.pnlForgotMsg.Name = "pnlForgotMsg";
            this.pnlForgotMsg.Size = new System.Drawing.Size(608, 283);
            this.pnlForgotMsg.TabIndex = 0;
            // 
            // lblForgotMsg2
            // 
            this.lblForgotMsg2.AutoSize = true;
            this.lblForgotMsg2.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotMsg2.ForeColor = System.Drawing.Color.Red;
            this.lblForgotMsg2.Location = new System.Drawing.Point(328, 124);
            this.lblForgotMsg2.Name = "lblForgotMsg2";
            this.lblForgotMsg2.Size = new System.Drawing.Size(108, 36);
            this.lblForgotMsg2.TabIndex = 1;
            this.lblForgotMsg2.Text = "ADMIN";
            // 
            // lblForgotMsg
            // 
            this.lblForgotMsg.AutoSize = true;
            this.lblForgotMsg.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotMsg.Location = new System.Drawing.Point(21, 124);
            this.lblForgotMsg.Name = "lblForgotMsg";
            this.lblForgotMsg.Size = new System.Drawing.Size(567, 36);
            this.lblForgotMsg.TabIndex = 0;
            this.lblForgotMsg.Text = "Please , Wait for The                     Approval.";
            // 
            // lblfootertext
            // 
            this.lblfootertext.AutoSize = true;
            this.lblfootertext.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfootertext.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblfootertext.Location = new System.Drawing.Point(302, 426);
            this.lblfootertext.Name = "lblfootertext";
            this.lblfootertext.Size = new System.Drawing.Size(199, 15);
            this.lblfootertext.TabIndex = 7;
            this.lblfootertext.Text = "Govt.BDPension -Academic Project";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(658, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ForgotMsgFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblfootertext);
            this.Controls.Add(this.pnlForgotMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotMsgFrom";
            this.Text = "ForgotMsgFrom";
            this.pnlForgotMsg.ResumeLayout(false);
            this.pnlForgotMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlForgotMsg;
        private System.Windows.Forms.Label lblForgotMsg;
        private System.Windows.Forms.Label lblForgotMsg2;
        private System.Windows.Forms.Label lblfootertext;
        private System.Windows.Forms.Button btnBack;
    }
}