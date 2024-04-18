using System;

namespace SplitTheBillLibrary
{
    /// <summary>
    /// Provides functionality to calculate the amount of tip each patron should pay based on the total price and tip percentage.
    /// Name: Avinash Nagaiah
    /// Student Id: A00227141
    /// </summary>
    public class TipPerPersonCalculator
    {
        public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
        {
            if (numberOfPatrons <= 0)
            {
                throw new ArgumentException("Number of patrons must be greater than zero.", nameof(numberOfPatrons));
            }

            if (tipPercentage < 0)
            {
                throw new ArgumentException("Tip percentage cannot be negative.", nameof(tipPercentage));
            }

            decimal totalTip = price * (decimal)(tipPercentage / 100.0);
            return Math.Round(totalTip / numberOfPatrons, 2, MidpointRounding.AwayFromZero);
        }
    }
}
