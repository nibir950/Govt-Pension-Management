using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Govt.BDPension.Enums;
using Govt.BDPension.Session;

namespace Govt.BDPension.Forms
{
    public partial class PensionMenuForm : Form
    {
        public DashboardSource OpenedFrom { get; set; } = DashboardSource.DirectLogin;
        public PensionMenuForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Role == UserRole.SystemAdmin)
            {
                SysadDasBoard sysadDasBoard = new SysadDasBoard();
                sysadDasBoard.Show();
                this.Close();
            }
            else if(CurrentUser.Role == UserRole.PensionAdmin)
            {
                PensionMngForm pensionMngForm = new PensionMngForm();
                pensionMngForm.Show();
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
            EmployeesForm EmployeesForm = new EmployeesForm();
            EmployeesForm.Show();
            this.Hide();
        }

        private void btnPayouts_Click(object sender, EventArgs e)
        {
            PayoutsForm payoutsForm = new PayoutsForm();
            payoutsForm.ParentMenu = this;
            payoutsForm.Show();
            this.Hide();
        }

        private void btnPensionCal_Click(object sender, EventArgs e)
        {
            PensionCalForm pensionCalForm = new PensionCalForm();
            pensionCalForm.ParentMenu = this;
            pensionCalForm.Show();
            this.Hide();
        }

        private void btnRetireMgmt_Click(object sender, EventArgs e)
        {
            RetirementMgmt retirementMgmt = new RetirementMgmt();
            retirementMgmt.ParentMenu = this;
            retirementMgmt.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ParentMenu = this;  
            settingsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }

        private void PensionMenuForm_Load(object sender, EventArgs e)
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

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();

            DashBoardForm1 dashboardForm = new DashBoardForm1();

            dashboardForm.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(dashboardForm);
            dashboardForm.Show();

           /* DashBoardForm dashboardForm = new DashBoardForm();
            dashboardForm.ParentMenu = this;
            dashboardForm.Show();*/
            //this.Hide();
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();

            EmployeesForm2 employeesForm2  = new EmployeesForm2();

            employeesForm2.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(employeesForm2);
            employeesForm2.Show();

            /*EmployeesForm EmployeesForm = new EmployeesForm();
            EmployeesForm.Show();*/
           // this.Hide();

        }

        private void btnPayouts_Click_1(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();

            PayoutsForm1 payoutsForm1 = new PayoutsForm1();

            payoutsForm1.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(payoutsForm1);
            payoutsForm1.Show();
            /*PayoutsForm payoutsForm = new PayoutsForm();
            payoutsForm.ParentMenu = this;*/
            //payoutsForm.Show();
           // this.Hide();

        }

        private void btnPensionCal_Click_1(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();

            PensionCalForm1 pensionCalForm1 = new PensionCalForm1();

            pensionCalForm1.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(pensionCalForm1);
            pensionCalForm1.Show();
            /*PensionCalForm pensionCalForm = new PensionCalForm();
            pensionCalForm.ParentMenu = this;
            pensionCalForm.Show();*/
            // this.Hide();

        }

        private void btnRetireMgmt_Click_1(object sender, EventArgs e)
        {
            /* RetirementMgmt retirementMgmt = new RetirementMgmt();
             retirementMgmt.ParentMenu = this;
             retirementMgmt.Show();
             this.Hide();*/
            pnlRight.Controls.Clear();

            RetirementMgmt1 retirement = new RetirementMgmt1();

            retirement.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(retirement);
            retirement.Show();

        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ParentMenu = this;
            settingsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserRole.SystemAdmin == CurrentUser.Role)
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
            /*LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();*/
        }
    }
}
