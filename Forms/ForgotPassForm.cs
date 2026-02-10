using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Govt.BDPension.Forms
{
    public partial class ForgotPassForm : Form
    {
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            string govtId = txtGovtId.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(govtId))
            {
                MessageBox.Show(
                    "Please enter your Govt. ID.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtGovtId.Focus();
                return;
            }

            if (govtId == "admin")
            {
                MessageBox.Show(
                    "Please check your official mail to change password.",
                    "Password Reset",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else if (govtId == "pensionadmin" || govtId =="pensionmanager" || govtId =="viewer")
            {
                ForgotMsgFrom forgotMsg = new ForgotMsgFrom();
                forgotMsg.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Input.", "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
