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
    public partial class AddUser1 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
       
        public AddUser1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string govtIdText = txtEmpId.Text.Trim();
            string passwordText = txtSalary.Text.Trim();

            // 
           /* if (string.IsNullOrWhiteSpace(govtIdText))
            {
                MessageBox.Show("Please enter Employee ID.",
                    "Missing Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordText))
            {
                MessageBox.Show("Please enter Password.",
                    "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return;
            }

            
            bool okEmpId = int.TryParse(govtIdText, out int empId);
            bool okPassword = int.TryParse(passwordText, out int password);

            
            if (!okEmpId || govtIdText.Length != 10)
            {
                MessageBox.Show("Employee ID must be exactly 10 digit number.",
                    "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmpId.Focus();
                return;
            }

            if (!okPassword || passwordText.Length != 6)
            {
                MessageBox.Show("Password must be exactly 6 digit number.",
                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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


            /*

            else 
            {    
                MessageBox.Show("Employee ID must be a 10-digit number and Password must be a 6-digit number.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           /* ParentPanel.Controls.Clear();
            ParentPanel.Visible = false;*/

            /*EmployeesForm2 employeesForm = new EmployeesForm2();
            employeesForm.Show();*/
            /*this.Hide();
            this.ParentMenu.Show();*/
        }
    }
}
