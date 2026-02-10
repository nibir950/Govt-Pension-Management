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
    public partial class ViewMenuForm : Form
    {
        public DashboardSource OpenedFrom { get; set; } = DashboardSource.DirectLogin;
        public Form ParentMenu { get; set; }
        public ViewMenuForm()
        {
            InitializeComponent();
        }

        private void ViewMenuForm_Load(object sender, EventArgs e)
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
                lblRole.Text = "Viewer";
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();

            ViewEmpForm1 viewEmpForm1 = new ViewEmpForm1();

            viewEmpForm1.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(viewEmpForm1);
            viewEmpForm1.Show();
            /* ViewEmp viewEmp = new ViewEmp();
             viewEmp.ParentMenu = this;
             viewEmp.Show();
             this.Hide();*/
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashBoardForm dashboardForm = new DashBoardForm();
            dashboardForm.ParentMenu = this;
            dashboardForm.Show();
            this.Hide();
        }

        private void btnPensionCal_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();

            PensionCalForm1 pensionCalForm = new PensionCalForm1();

            pensionCalForm.Dock = DockStyle.Fill;
            pnlRight.Controls.Add(pensionCalForm);
            pensionCalForm.Show();
            /*PensionCalForm pensionCalForm = new PensionCalForm();
            pensionCalForm.ParentMenu = this;
            pensionCalForm.Show();
            this.Hide();*/
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
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblViewer_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
