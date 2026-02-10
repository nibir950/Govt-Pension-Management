using Govt.BDPension.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govt.BDPension.Models
{
    public static class PensionSettings
    {
        private static PensionConfig _config;

        static PensionSettings()
        {
            LoadSettings();
        }

        public static void LoadSettings()
        {
            _config = SettingsService.LoadSettings();
        }

        public static int RetirementAge
        {
            get => _config.RetirementAge;
            set { _config.RetirementAge = value; SaveSettings(); }
        }

        public static int MinServiceYears
        {
            get => _config.MinServiceYears;
            set { _config.MinServiceYears = value; SaveSettings(); }
        }

        public static int MaxPensionPercentage
        {
            get => _config.MaxPensionPercentage;
            set { _config.MaxPensionPercentage = value; SaveSettings(); }
        }

        public static int FullPensionYears
        {
            get => _config.FullPensionYears;
            set { _config.FullPensionYears = value; SaveSettings(); }
        }

        private static void SaveSettings()
        {
            SettingsService.SaveSettings(_config);
        }
    }
}
