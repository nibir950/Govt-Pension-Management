using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Govt.BDPension.Enums;
using Govt.BDPension.Session;

namespace Govt.BDPension.Forms
{
    public partial class LoginForm : Form
    {
        public static int count = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string govtIdText = txtGovtId.Text.Trim();
            string passwordText = txtPassword.Text.Trim();

           
            if (string.IsNullOrWhiteSpace(govtIdText))
            {
                MessageBox.Show("Please enter a username.", "Missing Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGovtId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordText))
            {
                MessageBox.Show("Please enter a password.", "Missing Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            
            bool okGovtId = int.TryParse(govtIdText, out int govtId);
            bool okPassword = int.TryParse(passwordText, out int password);

            if ( govtIdText.Length != 10)
            {
                MessageBox.Show("Govt ID must be a 10 digit number.");
                txtGovtId.Focus();
                return;
            }

            if (passwordText.Length != 6)
            {
                MessageBox.Show("Password must be a 6 digit number.");
                txtPassword.Focus();
                return;
            }


            string sql1 = "SELECT userName, password FROM SystemAdmin WHERE  userName='" + this.txtGovtId.Text + "' AND password='" + this.txtPassword.Text + "';";

                DataAccess da1 = new DataAccess();
                DataSet ds1 = da1.ExecuteQuery(sql1);

                if (ds1.Tables[0].Rows.Count == 1)
                {
                    CurrentUser.Role = UserRole.SystemAdmin;
                    SysadDasBoard dash = new SysadDasBoard();
                    dash.Show();
                    this.Hide();

                    count = 1;

                    return;
                }
                string sql2 = "SELECT userName, password FROM PensionAdmin WHERE  userName='" + this.txtGovtId.Text + "' AND password='" + this.txtPassword.Text + "';";


                DataAccess da2 = new DataAccess();
                DataSet ds2 = da2.ExecuteQuery(sql2);

                if (ds2.Tables[0].Rows.Count == 1)
                {
                    CurrentUser.Role = UserRole.PensionAdmin;
                    PensionMngForm pmng = new PensionMngForm();
                    pmng.Show();
                    this.Hide();
                    return;
                }

                string sql3 = "SELECT userName, password FROM Manager WHERE  userName='" + this.txtGovtId.Text + "' AND password='" + this.txtPassword.Text + "';";


                DataAccess da3 = new DataAccess();
                DataSet ds3 = da3.ExecuteQuery(sql3);

                if (ds3.Tables[0].Rows.Count == 1)
                {
                    CurrentUser.Role = UserRole.PensionManager;
                    ManMenuForm mng = new ManMenuForm();
                    mng.Show();
                    this.Hide();
                    return;
                }
                string sql4 = "SELECT userName, password FROM Viewer WHERE  userName='" + this.txtGovtId.Text + "' AND password='" + this.txtPassword.Text + "';";


                DataAccess da4 = new DataAccess();
                DataSet ds4 = da4.ExecuteQuery(sql4);

                if (ds4.Tables[0].Rows.Count == 1)
                {
                    CurrentUser.Role = UserRole.Viewer;
                    ViewMenuForm vmenu = new ViewMenuForm();
                    vmenu.Show();
                    this.Hide();
                    return;
                }
                

            
        }

        private void linkForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassForm forgotPass = new ForgotPassForm();
            forgotPass.Show(this);
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
