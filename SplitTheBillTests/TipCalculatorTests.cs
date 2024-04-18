using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitTheBillLibrary;
using System;
using System.Collections.Generic;

namespace SplitTheBillTests
{
    [TestClass]
    public class TipCalculatorTests
    {
        private readonly TipCalculator _tipCalculator = new TipCalculator();

        // Tests that the method correctly calculates individual tips based on meal costs and a tip percentage.
        [TestMethod]
        public void CalculateIndividualTips_StandardScenario_ReturnsCorrectTips()
        {
            var mealCosts = new Dictionary<string, decimal> { { "Arvind", 100m }, { "Sudan", 200m }, { "Avinash", 300m } };
            float tipPercentage = 10;
            var expected = new Dictionary<string, decimal> { { "Arvind", 10m }, { "Sudan", 20m }, { "Avinash", 30m } };

            var actual = _tipCalculator.CalculateIndividualTips(mealCosts, tipPercentage);

            foreach (var person in expected.Keys)
            {
                Assert.AreEqual(expected[person], actual[person], 0.01m, $"Incorrect tip for {person}.");
            }
        }

        // Tests that the method correctly handles and calculates zero tip for zero cost meals, while properly calculating others.
        [TestMethod]
        public void CalculateIndividualTips_ZeroCostMeal_IgnoresZeroInCalculation()
        {
            var mealCosts = new Dictionary<string, decimal> { { "Arvind", 0m }, { "Sudan", 200m }, { "Avinash", 300m } };
            float tipPercentage = 10;
            var expected = new Dictionary<string, decimal> { { "Arvind", 0m }, { "Sudan", 20m }, { "Avinash", 30m } };

            var actual = _tipCalculator.CalculateIndividualTips(mealCosts, tipPercentage);

            foreach (var person in expected.Keys)
            {
                Assert.AreEqual(expected[person], actual[person], 0.01m, $"Incorrect tip for {person}.");
            }
        }

        // Tests that the method returns an empty dictionary when given an empty meal costs dictionary.
        [TestMethod]
        public void CalculateIndividualTips_EmptyMealCosts_ReturnsEmptyDictionary()
        {
            var mealCosts = new Dictionary<string, decimal>();
            float tipPercentage = 10;

            var actual = _tipCalculator.CalculateIndividualTips(mealCosts, tipPercentage);

            Assert.IsNotNull(actual);
            Assert.AreEqual(0, actual.Count);
        }

        // Tests that the method throws an ArgumentException when meal costs are null.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected an ArgumentException for null meal costs.")]
        public void CalculateIndividualTips_NullMealCosts_ThrowsArgumentException()
        {
            _tipCalculator.CalculateIndividualTips(null, 10);
        }

        // Tests that the method throws an ArgumentException when the tip percentage is negative.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected an ArgumentException for negative tip percentage.")]
        public void CalculateIndividualTips_NegativeTipPercentage_ThrowsArgumentException()
        {
            var mealCosts = new Dictionary<string, decimal> { { "Arvind", 100m } };
            _tipCalculator.CalculateIndividualTips(mealCosts, -10);
        }
    }
}
