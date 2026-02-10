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
    public partial class EmployeesForm : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public EmployeesForm()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
            dgvMngEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void PopulateGridView(string sql = "select Name, EmployeeId,Department,Joiningdate,Status,Salary from SysEmpAdd ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvMngEmp.AutoGenerateColumns = true;
            this.dgvMngEmp.DataSource = this.Ds.Tables[0];
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            PensionMenuForm menu = new PensionMenuForm();
            menu.Parent = this;
            menu.Show(this);
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
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

        private void dgvMngEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            PensionMngForm pensionMngForm = new PensionMngForm();
            pensionMngForm.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
