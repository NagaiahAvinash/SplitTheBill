using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitTheBillLibrary;
using System;

namespace SplitTheBillTests
{
    [TestClass]
    public class BillSplitterTests
    {
        private readonly BillSplitter _billSplitter = new BillSplitter();

        // Tests that the amount is split evenly among four people.
        [TestMethod]
        public void SplitAmount_EvenlyBetweenFourPeople_ReturnsCorrectAmount()
        {
            
            decimal amount = 100m;
            int numberOfPeople = 4;
            decimal expected = 25m;

            
            decimal result = _billSplitter.SplitAmount(amount, numberOfPeople);

            
            Assert.AreEqual(expected, result, "The split amount should be 25 per person.");
        }

        // Tests that zero amount results in zero split for any number of people.
        [TestMethod]
        public void SplitAmount_ZeroAmount_ReturnsZero()
        {
            
            decimal amount = 0m;
            int numberOfPeople = 4;
            decimal expected = 0m;

            
            decimal result = _billSplitter.SplitAmount(amount, numberOfPeople);

            
            Assert.AreEqual(expected, result, "The split amount should be 0 when the total amount is 0.");
        }

        // Tests that the split amount is correctly rounded to two decimal places.
        [TestMethod]
        public void SplitAmount_NonIntegerDivision_RoundsCorrectly()
        {
            
            decimal amount = 10m;
            int numberOfPeople = 3;
            decimal expected = 3.33m; 

            
            decimal result = _billSplitter.SplitAmount(amount, numberOfPeople);

            
            Assert.AreEqual(expected, result, "The split amount should be correctly rounded to two decimal places.");
        }

        // Tests that splitting with one person returns the original amount.
        [TestMethod]
        public void SplitAmount_WithOnePerson_ReturnsOriginalAmount()
        {
            
            decimal amount = 123.45m;
            int numberOfPeople = 1;
            decimal expected = 123.45m;

            
            decimal result = _billSplitter.SplitAmount(amount, numberOfPeople);

            
            Assert.AreEqual(expected, result, "The split amount should be the same as the original amount when there is only one person.");
        }
        
        //below methods are written to see the exceptions
        // Tests that providing a negative number of people throws an ArgumentException.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SplitAmount_NegativeNumberOfPeople_ThrowsArgumentException()
        {
            
            decimal amount = 100m;
            int numberOfPeople = -1; // This should trigger the exception 1

            
            _billSplitter.SplitAmount(amount, numberOfPeople);

            
        }

        // Tests that specifying zero people throws an ArgumentException.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SplitAmount_NumberOfPeopleIsZero_ThrowsArgumentException()
        {
            
            decimal amount = 100m;
            int numberOfPeople = 0; // This should trigger the exception 2

            
            _billSplitter.SplitAmount(amount, numberOfPeople);

         
        }
    }
}
