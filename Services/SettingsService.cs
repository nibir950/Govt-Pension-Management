using Govt.BDPension.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Govt.BDPension.Services
{
    public static class SettingsService
    {
        private static string SettingsFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Data",
            "PensionSettings.xml");

        // Load settings from file
        public static PensionConfig LoadSettings()
        {
            try
            {
                if (File.Exists(SettingsFilePath))
                {
                    var serializer = new XmlSerializer(typeof(PensionConfig));
                    using (var reader = new StreamReader(SettingsFilePath))
                    {
                        return (PensionConfig)serializer.Deserialize(reader);
                    }
                }
            }
            catch { }

            // Return default if file doesn't exist or error
            return GetDefaultSettings();
        }

        // Save settings to file
        public static void SaveSettings(PensionConfig config)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(SettingsFilePath));
                var serializer = new XmlSerializer(typeof(PensionConfig));
                using (var writer = new StreamWriter(SettingsFilePath))
                {
                    serializer.Serialize(writer, config);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to save settings: {ex.Message}");
            }
        }

        // Default settings (first time setup)
        private static PensionConfig GetDefaultSettings()
        {
            return new PensionConfig
            {
                RetirementAge = 60,
                MinServiceYears = 10,
                MaxPensionPercentage = 70,
                FullPensionYears = 30,
                RankPolicies = new List<RankPolicyData>
                {
                    new RankPolicyData { RankName = "Manager", BonusPercentage = 10, AllowHouseRent = true, AllowMedical = true, AllowTransport = true, AllowUtility = true },
                    new RankPolicyData { RankName = "Team Lead", BonusPercentage = 5, AllowHouseRent = true, AllowMedical = true, AllowTransport = false, AllowUtility = false },
                    new RankPolicyData { RankName = "Senior Employee", BonusPercentage = 0, AllowHouseRent = true, AllowMedical = true, AllowTransport = false, AllowUtility = false },
                    new RankPolicyData { RankName = "Junior Employee", BonusPercentage = -5, AllowHouseRent = false, AllowMedical = true, AllowTransport = false, AllowUtility = false }
                }
            };
        }
    }
}