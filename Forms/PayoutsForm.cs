using Govt.BDPension.Enums;
using Govt.BDPension.Session;
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
    public partial class PayoutsForm : Form
    {
        public Form ParentMenu { get; set; }
        public PayoutsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
             if (ParentMenu != null)
            {
                ParentMenu.Show();
                this.Close();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void PayoutsForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == UserRole.SystemAdmin)
            {
                lblRole.Text = "System Admin";
            }
            else if (CurrentUser.Role == UserRole.PensionAdmin)
            {
                lblRole.Text = "Pension Admin";
            }
            else
            {
                lblRole.Text = "Unknown role";
            }
        }
    }
}
