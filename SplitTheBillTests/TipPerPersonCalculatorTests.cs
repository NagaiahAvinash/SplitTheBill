using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitTheBillLibrary;
using System;

namespace SplitTheBillTests
{
    [TestClass]
    public class TipPerPersonCalculatorTests
    {
        private readonly TipPerPersonCalculator _tipPerPersonCalculator = new TipPerPersonCalculator();

        // Tests that the tip per person is correctly calculated under standard conditions.
        [TestMethod]
        public void CalculateTipPerPerson_StandardTip_CalculatesCorrectly()
        {
            
            decimal price = 200m;
            int numberOfPatrons = 4;
            float tipPercentage = 15f;
            decimal expectedTipPerPerson = 7.5m; 

            
            decimal result = _tipPerPersonCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            
            Assert.AreEqual(expectedTipPerPerson, result, "The tip per person calculated is incorrect.");
        }

        // Tests that the tip per person is correctly calculated with a high tip percentage.
        [TestMethod]
        public void CalculateTipPerPerson_HighTipPercentage_CalculatesCorrectly()
        {
            
            decimal price = 150m;
            int numberOfPatrons = 3;
            float tipPercentage = 20f;
            decimal expectedTipPerPerson = 10m; 

            
            decimal result = _tipPerPersonCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            
            Assert.AreEqual(expectedTipPerPerson, result, "The tip per person calculated is incorrect.");
        }

        // Tests that the tip per person is correctly calculated even with a low total price.
        [TestMethod]
        public void CalculateTipPerPerson_LowPrice_CalculatesCorrectly()
        {
            
            decimal price = 50m;
            int numberOfPatrons = 5;
            float tipPercentage = 10f;
            decimal expectedTipPerPerson = 1m; // Expected calculation: (50 * 0.10) / 5

            
            decimal result = _tipPerPersonCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            
            Assert.AreEqual(expectedTipPerPerson, result, "The tip per person calculated is incorrect.");
        }

        // these below two extra methods are implemented to see the exceptions
        // Tests that providing a negative tip percentage results in an ArgumentException.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTipPerPerson_NegativeTipPercentage_ThrowsArgumentException()
        {
            
            decimal price = 100m;
            int numberOfPatrons = 3;
            float tipPercentage = -5f; 

            
            _tipPerPersonCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            
        }

        // Tests that specifying zero patrons results in an ArgumentException.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTipPerPerson_ZeroPatrons_ThrowsArgumentException()
        {
            
            decimal price = 200m;
            int numberOfPatrons = 0; 
            float tipPercentage = 10f;

            
            _tipPerPersonCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            
        }
    }
}
