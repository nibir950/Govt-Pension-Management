namespace Govt.BDPension.Forms
{
    partial class ForgotPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassForm));
            this.lblForgotPassNote = new System.Windows.Forms.Label();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.txtGovtId = new System.Windows.Forms.TextBox();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.btnReturnLogin = new System.Windows.Forms.Button();
            this.lblGovtID = new System.Windows.Forms.Label();
            this.lblfootertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForgotPassNote
            // 
            this.lblForgotPassNote.AutoSize = true;
            this.lblForgotPassNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblForgotPassNote.Location = new System.Drawing.Point(31, 133);
            this.lblForgotPassNote.Name = "lblForgotPassNote";
            this.lblForgotPassNote.Size = new System.Drawing.Size(860, 20);
            this.lblForgotPassNote.TabIndex = 25;
            this.lblForgotPassNote.Text = "Please enter your email address associated with your pension account. We will sen" +
    "d you a link to reset your password.";
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.Location = new System.Drawing.Point(281, 100);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(309, 33);
            this.lblForgotPass.TabIndex = 24;
            this.lblForgotPass.Text = "Forgot Your Password?";
            // 
            // txtGovtId
            // 
            this.txtGovtId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGovtId.Location = new System.Drawing.Point(169, 239);
            this.txtGovtId.Name = "txtGovtId";
            this.txtGovtId.Size = new System.Drawing.Size(528, 31);
            this.txtGovtId.TabIndex = 26;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.Goldenrod;
            this.btnForgotPass.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnForgotPass.Location = new System.Drawing.Point(304, 286);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(249, 45);
            this.btnForgotPass.TabIndex = 28;
            this.btnForgotPass.Text = "Send Reset Link";
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // btnReturnLogin
            // 
            this.btnReturnLogin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReturnLogin.Location = new System.Drawing.Point(354, 337);
            this.btnReturnLogin.Name = "btnReturnLogin";
            this.btnReturnLogin.Size = new System.Drawing.Size(162, 69);
            this.btnReturnLogin.TabIndex = 29;
            this.btnReturnLogin.Text = "Return to Login";
            this.btnReturnLogin.UseVisualStyleBackColor = true;
            this.btnReturnLogin.Click += new System.EventHandler(this.btnReturnLogin_Click);
            // 
            // lblGovtID
            // 
            this.lblGovtID.AutoSize = true;
            this.lblGovtID.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGovtID.Location = new System.Drawing.Point(165, 207);
            this.lblGovtID.Name = "lblGovtID";
            this.lblGovtID.Size = new System.Drawing.Size(71, 20);
            this.lblGovtID.TabIndex = 30;
            this.lblGovtID.Text = "Govt. ID";
            // 
            // lblfootertext
            // 
            this.lblfootertext.AutoSize = true;
            this.lblfootertext.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfootertext.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblfootertext.Location = new System.Drawing.Point(335, 426);
            this.lblfootertext.Name = "lblfootertext";
            this.lblfootertext.Size = new System.Drawing.Size(199, 15);
            this.lblfootertext.TabIndex = 31;
            this.lblfootertext.Text = "Govt.BDPension -Academic Project";
            // 
            // ForgotPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfootertext);
            this.Controls.Add(this.lblGovtID);
            this.Controls.Add(this.btnReturnLogin);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.txtGovtId);
            this.Controls.Add(this.lblForgotPassNote);
            this.Controls.Add(this.lblForgotPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassForm";
            this.Text = "ForgotPassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPassNote;
        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.TextBox txtGovtId;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.Button btnReturnLogin;
        private System.Windows.Forms.Label lblGovtID;
        private System.Windows.Forms.Label lblfootertext;
    }
}