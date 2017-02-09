using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdvancedCollection.Test
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void OperationsShouldReturnSumWhenCalledWithAddition()
        {
            var list = Enumerable.Range(1, 5).ToList();
            MathOperations mathOperations = new MathOperations();
            var result = mathOperations.Operation(list, (a, b) => a + b);
            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void OperationsShouldReturnSubWhenCalledWithSubtraction()
        {
            var list = Enumerable.Range(1, 5).ToList();
            MathOperations mathOperations = new MathOperations();
            var result = mathOperations.Operation(list, (a, b) => a - b);
            Assert.AreEqual(result, -13);
        }
    }
}
