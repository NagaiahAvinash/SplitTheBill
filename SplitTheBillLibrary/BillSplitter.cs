using System;

namespace SplitTheBillLibrary
{
    /// <summary>
    /// Provides functionality to split a bill amount evenly among a specified number of people.
    /// Name: Avinash Nagaiah
    /// Student Id: A00227141
    /// </summary>
    public class BillSplitter
    {
        public decimal SplitAmount(decimal amount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
            {
                throw new ArgumentException("Number of people must be greater than zero.", nameof(numberOfPeople));
            }
            return Math.Round(amount / numberOfPeople, 2, MidpointRounding.AwayFromZero);
        }
    }
}
