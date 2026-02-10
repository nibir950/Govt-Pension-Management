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
    public partial class UserRoleForm1 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public UserRoleForm1()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
            dgvUserControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PopulateGridView(string sql = "select Name, EmployeeId,Role from SysAdmUserCntrl ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvUserControl.AutoGenerateColumns = true;
            this.dgvUserControl.DataSource = this.Ds.Tables[0];
        }
        private void ClearAll()
        {
            this.richTextBox1.Clear();

        }
        private void dgvUserControl_doubleClick(object sender, EventArgs e)
        {
            if (dgvUserControl.CurrentRow != null)
            {
               
                try
                {
                    richTextBox1.Text =
                        dgvUserControl.CurrentRow.Cells["EmployeeId"].Value?.ToString();

                    cmbDept.Text =
                       dgvUserControl.CurrentRow.Cells["Role"].Value?.ToString();

                    
                    

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserControlAdd userControlAdd=new UserControlAdd();
            userControlAdd.Show();

        }

        private void dgvUserControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            try
            {
                string id = richTextBox1.Text.Trim();
                string role = cmbDept.Text.Trim();

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please select a user first.");
                    return;
                }

                
                if (role == "Viewer")
                {
                    Sql = "DELETE FROM Viewer WHERE userName= '" + id + "'";
                    Da.ExecuteUpdateQuery(Sql);
                }
                else if (role == "Pension Admin")
                {
                    Sql = "DELETE FROM PensionAdmin WHERE userName = '" + id + "'";
                    Da.ExecuteUpdateQuery(Sql);
                }
                else if (role == "Pension Manager")
                {
                    Sql = "DELETE FROM Manager WHERE userName = '" + id + "'";
                    Da.ExecuteUpdateQuery(Sql);
                }

                this.Sql = @"delete from SysAdmUserCntrl
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
    }
}
