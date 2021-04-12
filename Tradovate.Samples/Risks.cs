/*
 *
 * Tradovate API, Samples.
 *
*/

using System;
using System.Linq;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Risks
    {
        public static void ShowRiskLimits(Account account)
        {
            var risksApi = new RisksApi();
            var positionLimits = risksApi.UserAccountPositionLimitDependents(account.Id);
            foreach (var positionLimit in positionLimits)
            {
                Console.WriteLine(positionLimit);
                var riskParameters = risksApi.UserAccountRiskParameterDependents(positionLimit.Id);
                foreach (var riskParameter in riskParameters)
                {
                    Console.WriteLine(riskParameter);
                }
            }
            if (positionLimits.Count == 0)
            {
                Console.WriteLine("This account doesn't have user-defined risk limits");
            }
        }

        public static void SetMaxOverallPositionLimit(Account account, int maxExposedPos)
        {
            var name = "Max Exposed Position";
            var risksApi = new RisksApi();
            // Find or create a position risk limit entity - an entity that describes a threshold level
            var positionLimits = risksApi.UserAccountPositionLimitDependents(account.Id);
            var exposureRiskLimit =
                positionLimits.FirstOrDefault(x => x.Description == name && x.TotalBy == UserAccountPositionLimit.TotalByEnum.Overall);
            if (exposureRiskLimit == null)
            {
                Console.WriteLine($"'{name}' risk limit is not found. Creating a new one.");
                var request = new UserAccountPositionLimit(
                    accountId: account.Id,
                    active: true,
                    totalBy: UserAccountPositionLimit.TotalByEnum.Overall,
                    description: name,
                    exposedLimit: maxExposedPos);
                exposureRiskLimit = risksApi.UserAccountPositionLimitCreate(request);
            }
            else if (exposureRiskLimit.ExposedLimit != maxExposedPos || exposureRiskLimit.Active != true)
            {
                Console.WriteLine($"'{name}' risk limit is found, but doesn't match new requirements. Updating old one.");
                exposureRiskLimit.ExposedLimit = maxExposedPos;
                exposureRiskLimit.Active = true;
                exposureRiskLimit = risksApi.UserAccountPositionLimitUpdate(exposureRiskLimit);
            }
            else
            {
                Console.WriteLine($"'{name}' risk limit is found and it matches new requirements.");
            }

            // Now find or create "hard limit" risk limit parameter - an entity that specifies
            // what to do when the thresold reached.
            // "hard limit" tells to reject orders over the threshold.
            var riskLimitParams = risksApi.UserAccountRiskParameterDependents(exposureRiskLimit.Id);
            var hardLimitParam = riskLimitParams.FirstOrDefault(x => x.HardLimit == true);
            if (hardLimitParam == null)
            {
                Console.WriteLine($"Hard-Limit parameter is not found. Creating a new one");
                hardLimitParam = new UserAccountRiskParameter(
                    userAccountPositionLimitId: exposureRiskLimit.Id,
                    hardLimit: true);
                risksApi.UserAccountRiskParameterCreate(hardLimitParam);
            }
            else
            {
                Console.WriteLine($"Hard-Limit parameter exists already");
            }
        }

        public static void DeleteMaxOverallPositionLimit(Account account)
        {
            var name = "Max Exposed Position";
            var risksApi = new RisksApi();
            var positionLimits = risksApi.UserAccountPositionLimitDependents(account.Id);
            var exposureRiskLimit =
                positionLimits.FirstOrDefault(x => x.Description == name && x.TotalBy == UserAccountPositionLimit.TotalByEnum.Overall);
            if (exposureRiskLimit == null)
            {
                Console.WriteLine($"'{name}' risk limit is not found.");
            }
            else
            {
                Console.WriteLine($"'{name}' risk limit is found, deleting");
                var request = new DeleteUserAccountPositionLimit(userAccountPositionLimitId: exposureRiskLimit.Id);
                risksApi.DeleteUserAccountPositionLimit(request);
            }
        }

        public static void SetDailyLossLimit(Account account, double maxDailyLoss)
        {
            var risksApi = new RisksApi();
            var autoLiqRules = risksApi.UserAccountAutoLiqDependents(account.Id);
            var dailyLossRule = autoLiqRules.FirstOrDefault();
            if (dailyLossRule == null)
            {
                Console.WriteLine("Daily Loss Auto-Liq rule is not found. Create a new one");
                // id should be the same as account's id
                dailyLossRule = new UserAccountAutoLiq(id: account.Id, dailyLossAutoLiq: maxDailyLoss);
                risksApi.UserAccountAutoLiqCreate(dailyLossRule);
            }
            else if (dailyLossRule.DailyLossAutoLiq != maxDailyLoss)
            {
                Console.WriteLine("Daily Loss Auto-Liq rule exists, but Daily Loss Auto-Liq doesn't match new requirements. Updating old one");
                // id should be the same as account's id
                dailyLossRule.DailyLossAutoLiq = maxDailyLoss;
                risksApi.UserAccountAutoLiqUpdate(dailyLossRule);
            }
            else
            {
                Console.WriteLine("Daily Loss Auto-Liq rule exists and Daily Loss Auto-Liq matches the new value");
            }
        }
    }
}