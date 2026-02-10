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
    public partial class ManEmpForm : Form
    {
        public ManEmpForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManMenuForm menu = new ManMenuForm();
            menu.Show(this);
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show(this);  
            this.Hide();
        }

        private void ManEmpForm_Load(object sender, EventArgs e)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
