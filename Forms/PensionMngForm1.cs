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
    public partial class PensionMngForm1 : UserControl
    {
        public PensionMngForm1()
        {
            InitializeComponent();
        }

        private void PensionMngForm1_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == UserRole.SystemAdmin)
            {
                lblRole.Text = "System Admin";
            }
            else if (CurrentUser.Role == UserRole.PensionAdmin)
            {
                lblRole.Text = "Pension Admin";
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

        private void btnPenAdmin_Click(object sender, EventArgs e)
        {
           
            PensionMenuForm pensionMenu = new PensionMenuForm();
            
            pensionMenu.Show();
           
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void btnPenManager_Click(object sender, EventArgs e)
        {
            ManMenuForm pensionMenu = new ManMenuForm();
            pensionMenu.OpenedFrom = DashboardSource.FromSystemAdmin;
            pensionMenu.Show();
            this.Hide();
        }
    }
}
