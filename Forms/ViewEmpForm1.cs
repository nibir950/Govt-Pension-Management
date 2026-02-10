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
    public partial class ViewEmpForm1 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public ViewEmpForm1()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
            dgvViewEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PopulateGridView(string sql = "select Name,EmployeeId,Department,Joiningdate,Salary from SysEmpAdd ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvViewEmp.AutoGenerateColumns = true;
            this.dgvViewEmp.DataSource = this.Ds.Tables[0];
        }

        private void dgvViewEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
