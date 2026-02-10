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


    public partial class Edit1 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public Edit1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {


           /* try
            {
                //string today = DateTime.Now.ToString("yyyy-MM-dd");

                this.Sql = "select * from SysEmpAdd where EmployeeId = '" + this.txtEmpId.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update SytmEmpAdd
            set Name = '" + this.txtName.Text + @"',
            EmployeeId = '" + this.txtEmpId.Text + @"',
            Salary = '" + this.txtSalary.Text + @"',
            Department = '" + this.cmbDepartment.Text + @"'
             JoiningDate= '" + this.txtJoinDate.Text + @"',
            where EmployeeId = '" + this.txtEmpId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtName.Text + " has been updated properly");
                    }
                    else
                    {
                        MessageBox.Show("Product information updation failed");
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred during updating  information\n\n" + exc.Message);
            }
*/
          
            try
            {
                this.Sql = "select * from SysEmpAdd where EmployeeId = '" + this.txtEmpId.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql =
                    "UPDATE SysEmpAdd SET " +
                    "Name = '" + this.txtName.Text + "', " +
                    "Salary = '" + this.txtSalary.Text + "', " +
                    "Department = '" + this.cmbDepartment.Text + "' " +
                    "WHERE EmployeeId = '" + this.txtEmpId.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Employee information updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                    }
                }
                else
                {
                    MessageBox.Show("Employee not found");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while updating information\n\n" + exc.Message);
            }
        }


    
}
}
