using System;
using System.Collections.Generic;

namespace SplitTheBillLibrary
{
    /// <summary>
    /// Calculates individual tips based on each person's meal cost and a given tip percentage.
    /// Name: Avinash Nagaiah
    /// Student Id: A00227141
    /// </summary>
    public class TipCalculator
    {
        public Dictionary<string, decimal> CalculateIndividualTips(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            if (mealCosts == null)
                throw new ArgumentException("Meal costs cannot be null.", nameof(mealCosts));

            if (mealCosts.Count == 0)
                return new Dictionary<string, decimal>(); 

            if (tipPercentage < 0)
                throw new ArgumentException("Tip percentage cannot be negative.", nameof(tipPercentage));

            var tipAmounts = new Dictionary<string, decimal>();
            decimal totalMealCost = 0m;

            foreach (var cost in mealCosts.Values)
            {
                if (cost > 0) totalMealCost += cost;
            }

            foreach (var entry in mealCosts)
            {
                if (entry.Value > 0)
                {
                    decimal weight = entry.Value / totalMealCost;
                    decimal tipForPerson = weight * totalMealCost * (decimal)(tipPercentage / 100.0);
                    tipAmounts[entry.Key] = Math.Round(tipForPerson, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    tipAmounts[entry.Key] = 0m; 
                }
            }

            return tipAmounts;
        }
    }
}
