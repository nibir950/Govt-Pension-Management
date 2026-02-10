using Govt.BDPension.Enums;
using Govt.BDPension.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Govt.BDPension.Forms
{
    public partial class SysadDasBoard : Form
    {
        public SysadDasBoard()
        {
            InitializeComponent();
        }

        //lblRole.Text = "SystemAdmin";
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Close();
        }

        private void btnPensionMng_Click(object sender, EventArgs e)
        {
           /* PensionMngForm PensionManage = new PensionMngForm();
            PensionManage.Show();
            this.Hide();*/
           panelRight.Controls.Clear();
            PensionMngForm1 pensionMngForm1 = new PensionMngForm1();
           
            pensionMngForm1.Dock= DockStyle.Fill;
            panelRight.Controls.Add(pensionMngForm1);
            pensionMngForm1.Show();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress!!");
            return;
        }

        private void SysadDasBoard_Load(object sender, EventArgs e)
        {

            if (CurrentUser.Role == UserRole.SystemAdmin)
            {
                lblRole.Text = "System Admin";
            }
            else if (CurrentUser.Role == UserRole.PensionAdmin)
            {
                lblRole.Text = "Pension Admin";
            }
            else if(CurrentUser.Role == UserRole.PensionManager)
            {
                lblRole.Text = "Pension Manager";

            }
            else if (CurrentUser.Role == UserRole.Viewer)
            {
                lblRole.Text = "Viewer";

            }
            else
            {
                lblRole.Text = "Unknown role";
            }
        }

        private void btnUserControl_Click(object sender, EventArgs e)
        {
           /* UserRoleForm UserControl = new UserRoleForm();
            UserControl.Show();
            this.Hide();*/
           
                panelRight.Controls.Clear();
            UserRoleForm1 userRoleForm1 = new UserRoleForm1();

            userRoleForm1.Dock = DockStyle.Fill;
            panelRight.Controls.Add(userRoleForm1);
            userRoleForm1.Show();
        }

        private void btnViewer_Click(object sender, EventArgs e)
        {
            /*ViewMenuForm viewMenu = new ViewMenuForm();
            viewMenu.ParentMenu = this;
            viewMenu.Show();
            this.Hide();*/
            panelRight.Controls.Clear();
            ViewMenuForm1 viewMenuForm1 = new ViewMenuForm1();

            viewMenuForm1.Dock = DockStyle.Fill;
            panelRight.Controls.Add(viewMenuForm1);
            viewMenuForm1.Show();
        }

        private void btnSystemSetting_Click(object sender, EventArgs e)
        {

        }
    }
}

