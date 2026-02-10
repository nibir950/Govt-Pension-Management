using Govt.BDPension.Enums;
using Govt.BDPension.Models;
using Govt.BDPension.Session;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Govt.BDPension.Forms
{
    public partial class SettingsForm : Form
    {
        public Form ParentMenu { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Load role display
            if (CurrentUser.Role == UserRole.SystemAdmin)
            {
                lblRole.Text = "System Admin";
            }
            else if (CurrentUser.Role == UserRole.PensionAdmin)
            {
                lblRole.Text = "Pension Admin";
            }

            // Load pension settings
            LoadPensionSettings();

            // Load rank policies
            LoadRankPolicies();

            // Wire up ComboBox event
            cmbEmpRank.SelectedIndexChanged += cmbEmpRank_SelectedIndexChanged;
        }

        private void LoadPensionSettings()
        {
            rtxtStandardAge.Text = PensionSettings.RetirementAge.ToString();
            rtxtMinServeYear.Text = PensionSettings.MinServiceYears.ToString();
            rtxtMaxPercentage.Text = PensionSettings.MaxPensionPercentage.ToString();
            rtxtFullPension.Text = PensionSettings.FullPensionYears.ToString();
        }

        private void LoadRankPolicies()
        {
            cmbEmpRank.Items.Clear();
            cmbEmpRank.Items.AddRange(new[] { "Manager", "Team Lead", "Senior Employee", "Junior Employee" });

            if (cmbEmpRank.Items.Count > 0)
            {
                cmbEmpRank.SelectedIndex = 0;
                LoadSelectedRankPolicy();
            }
        }

        private void cmbEmpRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedRankPolicy();
        }

        private void LoadSelectedRankPolicy()
        {
            if (cmbEmpRank.SelectedItem == null) return;

            string rankName = cmbEmpRank.SelectedItem.ToString();
            var policies = RankPolicy.GetAllRankPolicies();
            var policy = policies.FirstOrDefault(p => p.RankName.Equals(rankName, StringComparison.OrdinalIgnoreCase));

            if (policy != null)
            {
                rtxtRankBonus.Text = policy.BonusPercentage.ToString();
                chbHouseRent.Checked = policy.AllowHouseRent;
                chbMedical.Checked = policy.AllowMedical;
                chbTransport.Checked = policy.AllowTransport;
                chbUtility.Checked = policy.AllowUtility;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Save pension settings
                if (int.TryParse(rtxtStandardAge.Text, out int retirementAge))
                    PensionSettings.RetirementAge = retirementAge;

                if (int.TryParse(rtxtMinServeYear.Text, out int minServiceYears))
                    PensionSettings.MinServiceYears = minServiceYears;

                if (int.TryParse(rtxtMaxPercentage.Text, out int maxPercent))
                    PensionSettings.MaxPensionPercentage = maxPercent;

                if (int.TryParse(rtxtFullPension.Text, out int fullPensionYears))
                    PensionSettings.FullPensionYears = fullPensionYears;

                // Save rank policy (if rank is selected)
                if (cmbEmpRank.SelectedItem != null)
                {
                    string rankName = cmbEmpRank.SelectedItem.ToString();
                    if (int.TryParse(rtxtRankBonus.Text, out int bonusPercent))
                    {
                        var updatedPolicy = new RankPolicyData
                        {
                            RankName = rankName,
                            BonusPercentage = bonusPercent,
                            AllowHouseRent = chbHouseRent.Checked,
                            AllowMedical = chbMedical.Checked,
                            AllowTransport = chbTransport.Checked,
                            AllowUtility = chbUtility.Checked
                        };

                        RankPolicy.UpdateRankPolicy(updatedPolicy);
                    }
                }

                PensionSettings.LoadSettings(); // Reload to refresh
                RankPolicy.LoadSettings();

                MessageBox.Show("All settings saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset all settings to defaults?", "Reset Settings",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var settingsPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "PensionSettings.json");
                    if (System.IO.File.Exists(settingsPath))
                    {
                        System.IO.File.Delete(settingsPath);
                    }
                }
                catch { }

                PensionSettings.LoadSettings();
                RankPolicy.LoadSettings();
                LoadPensionSettings();
                LoadRankPolicies();

                MessageBox.Show("Settings reset to defaults.", "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}