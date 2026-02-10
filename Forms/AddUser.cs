using Govt.BDPension.Enums;
using Govt.BDPension.Forms;
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
    public partial class AddUser : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public Form ParentMenu { get; set; }
        public AddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s = cmbDepartment.Text;

            
            string salary1 = "0";

            if (s == "Pension Admin")
            {
                salary1 = "95000";
            }
            else if (s == "Pension Manager")
            {
                salary1 = "75000";
            }
            else if (s == "Employee")
            {
                salary1 = "55000";
            }
            else if (s == "Viewer")   
            {
                salary1 = "35000";
            }

            try
            {
                string today = DateTime.Now.ToString("yyyy-MM-dd");   

                this.Sql = @"update SysEmpAdd
                    set 
                        Name = '" + this.txtName.Text + @"',
                        EmployeeId = '" + this.txtEmpId.Text + @"',
                        Status = 'Active',
                        Salary = '" + salary1 + @"',
                        Department = '" + this.cmbDepartment.Text + @"',
                        JoinDate = '" + today + @"'
                    where EmployeeId = '" + this.txtEmpId.Text + "';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(this.txtName.Text + " has been updated properly");
                }
                else
                {
                    MessageBox.Show("User update failed");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred during saving user information\n\n" + exc.Message);
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            /*
             string s = cmbDepartment.Text;


             string salary1 = "0";*/

            /* if (s == "Pension Admin")
             {
                 salary1 = "95000";
             }
             else if (s == "Pension Manager")
             {
                 salary1 = "75000";
             }
             else if (s == "Employee")
             {
                 salary1 = "55000";
             }
             else if (s == "Viewer")  
             {
                 salary1 = "35000";
             }*/
            string s = txtEmpId.Text;
           if (s.Length==5)
            { }

            try
            {
                
                string today = DateTime.Now.ToString("yyyy-MM-dd");   

                this.Sql = @"insert into SysEmpAdd
                    (Name, EmployeeId,  Salary, Department, JoiningDate)
                    values
                    ('" + this.txtName.Text + @"',
                     '" + this.txtEmpId.Text + @"',
                     '" + this.txtSalary.Text + @"',
                     '" + this.cmbDepartment.Text + @"',
                     '" + today + @"' )";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);


                

                if (count == 1)
                {
                    MessageBox.Show(this.txtName.Text + " has been updated properly");
                }
                else
                {
                    MessageBox.Show("User update failed");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred during saving user information\n\n" + exc.Message);
            }
        

    }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmployeesForm2 employeesForm = new EmployeesForm2();
            employeesForm.Show();

            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void txtName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}