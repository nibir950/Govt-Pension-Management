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
    public partial class PensionMngForm : Form
    {
        public PensionMngForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Close();
        }

        private void btnPenAdmin_Click(object sender, EventArgs e)
        {
            PensionMenuForm pensionMenu = new PensionMenuForm();
            pensionMenu.OpenedFrom = DashboardSource.FromSystemAdmin;
            pensionMenu.Show();
            this.Hide();
        }

        private void btnPenManager_Click(object sender, EventArgs e)
        {
            ManMenuForm pensionMenu = new ManMenuForm();
            pensionMenu.OpenedFrom = DashboardSource.FromSystemAdmin;
            pensionMenu.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(CurrentUser.Role == UserRole.SystemAdmin)
            {
                SysadDasBoard sd = new SysadDasBoard();
                sd.Show();
                this.Hide();


            }
            else if(CurrentUser.Role == UserRole.PensionAdmin)
            {
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
            }
                
        }

        private void PensionMngForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == UserRole.SystemAdmin)
            {
                lblRole.Text = "System Admin";
            }
            else if (CurrentUser.Role == UserRole.PensionAdmin)
            {
                lblRole.Text = "Pension Admin";
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
