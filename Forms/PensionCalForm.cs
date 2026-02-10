using Govt.BDPension.Enums;
using Govt.BDPension.Services;
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
    public partial class PensionCalForm : Form
    {
        public Form ParentMenu { get; set; }
        public PensionCalForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ParentMenu != null)
            {
                ParentMenu.Show();
                this.Close();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnCalPension_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBasicSal.Text.Trim(), out decimal basicSalary) || basicSalary <= 0)
            {
                MessageBox.Show("Please enter a valid basic salary.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBasicSal.Focus();
                return;
            }

            // 2. Get dates
            DateTime dateOfBirth = dateTimeBirth.Value.Date;
            DateTime dateOfJoin = dateTimeJoin.Value.Date;

            if (dateOfJoin <= dateOfBirth)
            {
                MessageBox.Show("Date of joining must be after date of birth.", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeJoin.Focus();
                return;
            }

            if (cmbEmpRank.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee rank.", "Missing Rank",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpRank.DroppedDown = true;
                return;
            }

            // 3. Extract rank text (remove the '1. ', '2. ' prefix)
            string rawRank = cmbEmpRank.SelectedItem.ToString();
            int dotIndex = rawRank.IndexOf(". ");
            string rank = dotIndex >= 0 ? rawRank.Substring(dotIndex + 2) : rawRank; // "Manager", "Team Lead", etc.

            // 4. Call calculator
            var calculator = new PensionCalculator();
            decimal monthlyPension;
            decimal lumpSum;
            string details;

            calculator.CalculatePension(
                basicSalary,
                dateOfBirth,
                dateOfJoin,
                rank,
                out monthlyPension,
                out lumpSum,
                out details);

            // 5. Display results
            lblMonthPensionNum.Text = monthlyPension.ToString("N2");
            lblLumpSumNum.Text = lumpSum.ToString("N2");

            MessageBox.Show(details, "Pension Calculation Details",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PensionCalForm_Load(object sender, EventArgs e)
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
    }
}
