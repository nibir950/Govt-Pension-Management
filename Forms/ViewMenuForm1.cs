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
    public partial class ViewMenuForm1 : UserControl
    {
        public ViewMenuForm1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ViewEmpForm1 viewEmpForm1 = new ViewEmpForm1();
            viewEmpForm1.Show();
            //this.Hide();
            /*Parent.Controls.Clear();
            viewEmpForm1.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(viewEmpForm1);*/
        }
    }
}
