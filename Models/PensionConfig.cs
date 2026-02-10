using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govt.BDPension.Models
{
    public class PensionConfig
    {
        public int RetirementAge { get; set; } = 60;
        public int MinServiceYears { get; set; } = 10;
        public int MaxPensionPercentage { get; set; } = 70;
        public int FullPensionYears { get; set; } = 30;

        public List<RankPolicyData> RankPolicies { get; set; } = new List<RankPolicyData>();
    }

    public class RankPolicyData
    {
        public string RankName { get; set; }
        public int BonusPercentage { get; set; }
        public bool AllowHouseRent { get; set; }
        public bool AllowMedical { get; set; }
        public bool AllowTransport { get; set; }
        public bool AllowUtility { get; set; }
    }
}
