using Govt.BDPension.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govt.BDPension.Services
{
    public class PensionCalculator
    {
        public void CalculatePension(
            decimal basicSalary,
            DateTime dateOfBirth,
            DateTime dateOfJoin,
            string rank,
            out decimal monthlyPension,
            out decimal lumpSum,
            out string detailsMessage)
        {
            DateTime today = DateTime.Today;

            // Age
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;

            // Years of service
            int yearsOfService = today.Year - dateOfJoin.Year;
            if (dateOfJoin.Date > today.AddYears(-yearsOfService)) yearsOfService--;

            // Eligibility
            if (age < PensionSettings.RetirementAge)
            {
                monthlyPension = 0m;
                lumpSum = 0m;
                detailsMessage = $"Not eligible: Age {age} is below retirement age {PensionSettings.RetirementAge}.";
                return;
            }

            if (yearsOfService < PensionSettings.MinServiceYears)
            {
                monthlyPension = 0m;
                lumpSum = 0m;
                detailsMessage = $"Not eligible: Years of service {yearsOfService} is below minimum {PensionSettings.MinServiceYears}.";
                return;
            }

            // Base percentage from service
            int cappedYears = Math.Min(yearsOfService, PensionSettings.FullPensionYears);
            decimal serviceFactor = (decimal)cappedYears / PensionSettings.FullPensionYears;
            decimal basePercent = serviceFactor * PensionSettings.MaxPensionPercentage;

            // Rank bonus/penalty
            int rankBonusPercent = RankPolicy.GetBonusPercentage(rank);
            decimal finalPercent = basePercent + rankBonusPercent;

            if (finalPercent < 0) finalPercent = 0;
            if (finalPercent > PensionSettings.MaxPensionPercentage)
                finalPercent = PensionSettings.MaxPensionPercentage;

            // Amounts
            monthlyPension = basicSalary * finalPercent / 100m;
            lumpSum = monthlyPension * 12m; // simple example: 12 months

            detailsMessage =
                $"Age: {age} years, Service: {yearsOfService} years (used {cappedYears}). " +
                $"Base %: {basePercent:0.##}% + rank bonus {rankBonusPercent}% = {finalPercent:0.##}% of basic salary.";
        }
    }
}