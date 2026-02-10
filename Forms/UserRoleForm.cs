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
    public partial class UserRoleForm : Form
    {
        public DashboardSource OpenedFrom { get; set; } = DashboardSource.DirectLogin;
        public Form ParentMenu { get; set; }
        public UserRoleForm()
        {
            InitializeComponent();
        }

        private void UserRoleForm_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Role == UserRole.SystemAdmin ||
                CurrentUser.Role == UserRole.PensionAdmin ||
                CurrentUser.Role == UserRole.PensionManager)
            {
                AddUser addUser = new AddUser();
                addUser.ParentMenu = this;  
                addUser.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not have permission to add users.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
