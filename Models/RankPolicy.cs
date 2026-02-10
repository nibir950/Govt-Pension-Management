using Govt.BDPension.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govt.BDPension.Models
{
    public static class RankPolicy
    {
        private static PensionConfig _config;

        static RankPolicy()
        {
            LoadSettings();
        }

        public static void LoadSettings()
        {
            _config = SettingsService.LoadSettings();
        }

        public static int GetBonusPercentage(string rank)
        {
            var policy = _config.RankPolicies.FirstOrDefault(r => r.RankName.Equals(rank, System.StringComparison.OrdinalIgnoreCase));
            return policy?.BonusPercentage ?? 0;
        }

        public static bool AllowHouseRent(string rank)
        {
            var policy = _config.RankPolicies.FirstOrDefault(r => r.RankName.Equals(rank, System.StringComparison.OrdinalIgnoreCase));
            return policy?.AllowHouseRent ?? false;
        }

        public static bool AllowMedical(string rank)
        {
            var policy = _config.RankPolicies.FirstOrDefault(r => r.RankName.Equals(rank, System.StringComparison.OrdinalIgnoreCase));
            return policy?.AllowMedical ?? false;
        }

        public static bool AllowTransport(string rank)
        {
            var policy = _config.RankPolicies.FirstOrDefault(r => r.RankName.Equals(rank, System.StringComparison.OrdinalIgnoreCase));
            return policy?.AllowTransport ?? false;
        }

        public static bool AllowUtility(string rank)
        {
            var policy = _config.RankPolicies.FirstOrDefault(r => r.RankName.Equals(rank, System.StringComparison.OrdinalIgnoreCase));
            return policy?.AllowUtility ?? false;
        }

        // New method to get all rank policies (for SettingsForm)
        public static System.Collections.Generic.List<RankPolicyData> GetAllRankPolicies()
        {
            return _config.RankPolicies;
        }

        // New method to update rank policy
        public static void UpdateRankPolicy(RankPolicyData updatedPolicy)
        {
            var existing = _config.RankPolicies.FirstOrDefault(r => r.RankName.Equals(updatedPolicy.RankName, System.StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                existing.BonusPercentage = updatedPolicy.BonusPercentage;
                existing.AllowHouseRent = updatedPolicy.AllowHouseRent;
                existing.AllowMedical = updatedPolicy.AllowMedical;
                existing.AllowTransport = updatedPolicy.AllowTransport;
                existing.AllowUtility = updatedPolicy.AllowUtility;
            }
            SettingsService.SaveSettings(_config);
        }
    }
}
