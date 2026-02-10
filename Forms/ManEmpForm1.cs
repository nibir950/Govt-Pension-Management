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
    public partial class ManEmpForm1 : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public ManEmpForm1()
        {
            InitializeComponent();
            Da = new DataAccess();
            PopulateGridView();
            dgvMngrControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PopulateGridView(string sql = "select Name, EmployeeId,Department,Salary,JoiningDate from SysEmpAdd ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvMngrControl.AutoGenerateColumns = true;
            this.dgvMngrControl.DataSource = this.Ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser adduser=new AddUser();
            //adduser.ParentMenu = this.ParentForm;
            adduser.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
