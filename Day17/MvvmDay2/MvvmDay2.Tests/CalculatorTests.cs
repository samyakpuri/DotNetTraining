using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MvvmDay2.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddMethodShoudReturnLongValueWhenTwoMinimumIntegersArePassed()
        {
            Calculator calculator = new Calculator();
            long sum = calculator.Add(Int32.MinValue, Int32.MinValue);
            Assert.AreEqual(sum, 2 * (long)Int32.MinValue);
        }

        [TestMethod]
        public void AddMethodShoudReturnLongValueWhenTwoMaximumIntegersArePassed()
        {
            Calculator calculator = new Calculator();
            long sum = calculator.Add(Int32.MaxValue, Int32.MaxValue);
            Assert.AreEqual(sum, 2 * (long)Int32.MaxValue);
        }

        [TestMethod]
        public void AddMethodShoudReturnLongValueWhenTwoHalfMinimumIntegersArePassed()
        {
            Calculator calculator = new Calculator();
            long sum = calculator.Add(Int32.MinValue/2, Int32.MinValue/2);
            Assert.AreEqual(sum, (Int32.MinValue / 2) + (Int32.MinValue / 2));
        }

        [TestMethod]
        public void AddMethodShoudReturnLongValueWhenTwoHalfMaximumIntegersArePassed()
        {
            Calculator calculator = new Calculator();
            long sum = calculator.Add(Int32.MaxValue/2, Int32.MaxValue/2);
            Assert.AreEqual(sum, (Int32.MaxValue / 2) + (Int32.MaxValue / 2));
        }
    }
}
