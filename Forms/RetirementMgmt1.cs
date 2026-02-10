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
    public partial class RetirementMgmt1 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public RetirementMgmt1()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
            dgvRtrMng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PopulateGridView(string sql = "select Name, EmployeeId,Department,Salary,JoiningDate from SysEmpAdd ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvRtrMng.AutoGenerateColumns = true;
            this.dgvRtrMng.DataSource = this.Ds.Tables[0];
        }
        private void lblAwaitReview_Click(object sender, EventArgs e)
        {

        }

        private void btnRetireThisYear_Click(object sender, EventArgs e)
        {

        }

        private void picSearch_Click(object sender, EventArgs e)
        {

        }

        private void pnlChoiceBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRtrMng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRetireThisYear_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "SELECT Name, EmployeeId, Department, Salary, JoiningDate " +
                    "FROM SysEmpAdd " +
                    "WHERE DATEADD(YEAR, 29, JoiningDate) >= DATEFROMPARTS(YEAR(GETDATE()), 1, 1) " +
                    "AND DATEADD(YEAR, 29, JoiningDate) <= DATEFROMPARTS(YEAR(GETDATE()), 12, 31) " +
                    "AND DATEADD(YEAR, 30, JoiningDate) > DATEFROMPARTS(YEAR(GETDATE()), 12, 31);";

                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvRtrMng.AutoGenerateColumns = true;
                this.dgvRtrMng.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employees retiring this year.\n" + ex.Message);
            }
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "SELECT Name, EmployeeId, Department, Salary, JoiningDate " +
                    "FROM SysEmpAdd " +
                    "WHERE DATEADD(YEAR, 30, JoiningDate) <= GETDATE();";

                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvRtrMng.AutoGenerateColumns = true;
                this.dgvRtrMng.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load archived employees.\n" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
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
