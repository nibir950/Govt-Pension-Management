using Govt.BDPension.Enums;
using Govt.BDPension.Services;
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
    public partial class ManMenuForm : Form
    {
        public DashboardSource OpenedFrom { get; set; } = DashboardSource.DirectLogin;
        public ManMenuForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (OpenedFrom == DashboardSource.FromSystemAdmin)
            {
                
                SysadDasBoard sysadDasBoard = new SysadDasBoard();
                sysadDasBoard.Show();
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
            

            if (UserRole.SystemAdmin == CurrentUser.Role)
            {
                SysadDasBoard sysadDasBoard = new SysadDasBoard();
                sysadDasBoard.Show();
                this.Close();
            }
            else if (UserRole.PensionAdmin == CurrentUser.Role)
            {
                PensionMngForm pensionMngForm = new PensionMngForm();
                pensionMngForm.Show();
                this.Close();
            }
            else if (UserRole.PensionManager == CurrentUser.Role)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashBoardForm dashboardForm = new DashBoardForm();
            dashboardForm.ParentMenu = this;   
            dashboardForm.Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();

            ManEmpForm1 manEmpForm = new ManEmpForm1();

            manEmpForm.Dock = DockStyle.Fill;
            panelRight.Controls.Add(manEmpForm);
            manEmpForm.Show();
            
            
        }

        private void btnPayouts_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();

            PayoutsForm1 payoutsForm = new PayoutsForm1();

            payoutsForm.Dock = DockStyle.Fill;
            panelRight.Controls.Add(payoutsForm);
            payoutsForm.Show();

        }

        private void btnPensionCal_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();

            PensionCalForm1 pensionCalForm = new PensionCalForm1();

            pensionCalForm.Dock = DockStyle.Fill;
            panelRight.Controls.Add(pensionCalForm);
            pensionCalForm.Show();
          
        }

        private void btnRetireMgmt_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();

            RetirementMgmt1 retirementMgmt = new RetirementMgmt1();
            retirementMgmt.Dock = DockStyle.Fill;
            panelRight.Controls.Add(retirementMgmt);
            retirementMgmt.Show();
            
           
        }

        private void ManMenuForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == UserRole.SystemAdmin)
            {
                lblRole.Text = "System Admin";
            }
            else if (CurrentUser.Role == UserRole.PensionAdmin)
            {
                lblRole.Text = "Pension Admin";
            }

            else if (CurrentUser.Role == UserRole.PensionManager)
            {
                lblRole.Text = "Pension Manager";
            }
            
            else
            {
                lblRole.Text = "Unknown role";
            }
        }
    }
}

