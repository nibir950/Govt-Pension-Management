namespace Govt.BDPension.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblPensionManagement = new System.Windows.Forms.Label();
            this.txtGovtId = new System.Windows.Forms.MaskedTextBox();
            this.lblAuthorizedd = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.linkForgotpass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblfootertext = new System.Windows.Forms.Label();
            this.lblGovtId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPensionManagement
            // 
            this.lblPensionManagement.AutoSize = true;
            this.lblPensionManagement.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionManagement.Location = new System.Drawing.Point(220, 94);
            this.lblPensionManagement.Name = "lblPensionManagement";
            this.lblPensionManagement.Size = new System.Drawing.Size(427, 38);
            this.lblPensionManagement.TabIndex = 0;
            this.lblPensionManagement.Text = "Govt. Pension Management";
            // 
            // txtGovtId
            // 
            this.txtGovtId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGovtId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtGovtId.Location = new System.Drawing.Point(362, 200);
            this.txtGovtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGovtId.Name = "txtGovtId";
            this.txtGovtId.Size = new System.Drawing.Size(210, 31);
            this.txtGovtId.TabIndex = 1;
            // 
            // lblAuthorizedd
            // 
            this.lblAuthorizedd.AutoSize = true;
            this.lblAuthorizedd.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorizedd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAuthorizedd.Location = new System.Drawing.Point(302, 135);
            this.lblAuthorizedd.Name = "lblAuthorizedd";
            this.lblAuthorizedd.Size = new System.Drawing.Size(263, 21);
            this.lblAuthorizedd.TabIndex = 2;
            this.lblAuthorizedd.Text = "AUTHORIZED PERSONNEL ONLY";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPassword.Location = new System.Drawing.Point(362, 272);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 31);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // linkForgotpass
            // 
            this.linkForgotpass.AutoSize = true;
            this.linkForgotpass.LinkColor = System.Drawing.Color.Black;
            this.linkForgotpass.Location = new System.Drawing.Point(442, 328);
            this.linkForgotpass.Name = "linkForgotpass";
            this.linkForgotpass.Size = new System.Drawing.Size(138, 20);
            this.linkForgotpass.TabIndex = 4;
            this.linkForgotpass.TabStop = true;
            this.linkForgotpass.Text = "Forgot Password?";
            this.linkForgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotpass_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Yellow;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(362, 379);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblfootertext
            // 
            this.lblfootertext.AutoSize = true;
            this.lblfootertext.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfootertext.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblfootertext.Location = new System.Drawing.Point(312, 491);
            this.lblfootertext.Name = "lblfootertext";
            this.lblfootertext.Size = new System.Drawing.Size(248, 19);
            this.lblfootertext.TabIndex = 6;
            this.lblfootertext.Text = "Govt.BDPension -Academic Project";
            // 
            // lblGovtId
            // 
            this.lblGovtId.AutoSize = true;
            this.lblGovtId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGovtId.Location = new System.Drawing.Point(264, 209);
            this.lblGovtId.Name = "lblGovtId";
            this.lblGovtId.Size = new System.Drawing.Size(84, 25);
            this.lblGovtId.TabIndex = 7;
            this.lblGovtId.Text = "Govt. ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(251, 276);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 25);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblGovtId);
            this.Controls.Add(this.lblfootertext);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkForgotpass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblAuthorizedd);
            this.Controls.Add(this.txtGovtId);
            this.Controls.Add(this.lblPensionManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPensionManagement;
        private System.Windows.Forms.MaskedTextBox txtGovtId;
        private System.Windows.Forms.Label lblAuthorizedd;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkForgotpass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblfootertext;
        private System.Windows.Forms.Label lblGovtId;
        private System.Windows.Forms.Label lblPassword;
    }
}