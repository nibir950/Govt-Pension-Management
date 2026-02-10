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
    public partial class EmployeesForm2 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public EmployeesForm2()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
            dgvMngEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pnlAdd1.Visible = false;
        }
        private void PopulateGridView(string sql = "select Name, EmployeeId,Department,Salary,JoiningDate from SysEmpAdd ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvMngEmp.AutoGenerateColumns = true;
            this.dgvMngEmp.DataSource = this.Ds.Tables[0];
        }
       private void ClearAll()
        {
            this.richTextBox1.Clear();
           
        }

        private void lblSearchEmployee_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpDicNote_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void EmployeesForm2_Load(object sender, EventArgs e)
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

            pnlAdd1.Visible = true; 
            pnlAdd1.Controls.Clear(); 
            AddUser1 addUser = new AddUser1(); 
            addUser.Dock = DockStyle.Fill;
            pnlAdd1.Controls.Add(addUser);
            /* AddUser1 addUser = new AddUser1
             {
                 Dock = DockStyle.Fill,
                 ParentPanel = pnlAdd1
             };

             // 🔔 Refresh grid after save
             addUser.UserSaved += () =>
             {
                 PopulateGridView();
                 pnlAdd1.Controls.Clear();
                 pnlAdd1.Visible = false;
             };

             pnlAdd1.Controls.Add(addUser);*/

            /* pnlAdd1.Visible = true;
             pnlAdd1.Controls.Clear();

             AddUser1 addUser = new AddUser1();
             addUser.Dock = DockStyle.Fill;

             pnlAdd1.Controls.Add(addUser);*/
            /* pnlAdd1.Visible = true;
             pnlAdd1.Controls.Clear();

             AddUser1 addUser = new AddUser1();

             addUser.Dock = DockStyle.Fill;
             addUser.Controls.Add(addUser);
             addUser.Show();*/
            /*AddUser add = new AddUser();
            add.Show();
            this.Hide();*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void dgvMngEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMngEmp_doubleClick(object sender, EventArgs e)
        {
            if (dgvMngEmp.CurrentRow != null)
            {
                /*try
                {
                    
                    this.richTextBox1.Text = dgvMngEmp.CurrentRow.Cells["EmployeeId"].Value?.ToString();
                    this.cmbDept.Text = dgvMngEmp.CurrentRow.Cells["Department"].Value?.ToString();
                    this.cmbYear.Text = dgvMngEmp.CurrentRow.Cells["Joiningdate"].Value?.ToString();
                    
                }*/
                try
                {
                    richTextBox1.Text =
                        dgvMngEmp.CurrentRow.Cells["EmployeeId"].Value?.ToString();

                    cmbDept.Text =
                        dgvMngEmp.CurrentRow.Cells["Department"].Value?.ToString();

                    DateTime joiningDate = Convert.ToDateTime(
                        dgvMngEmp.CurrentRow.Cells["Joiningdate"].Value
                    );

                    cmbYear.SelectedItem = joiningDate.Year.ToString();
                   // cmbDate.SelectedItem = joiningDate.Day.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
        } 
        //Edit -delete
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            try
            {
                string id = this.richTextBox1.Text;

                this.Sql = @"delete from SysEmpAdd
                    where EmployeeId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(this.richTextBox1.Text + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Id information deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }


        

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            pnlAdd1.Visible = true;
            pnlAdd1.Controls.Clear();
            Edit1  edit1 = new Edit1();
            edit1.Dock = DockStyle.Fill;
            pnlAdd1.Controls.Add(edit1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Da == null) return;

            string text = richTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                PopulateGridView();
                return;
            }

            try
            {
                this.Sql = $"select * from SysEmpAdd where EmployeeId like '{text}%'";
                PopulateGridView(this.Sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }
    }
}
