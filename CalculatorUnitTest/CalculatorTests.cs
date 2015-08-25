using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add()
        {
            var calculator = new Form1();
            var result = calculator.result(10,50);
            Assert.Equals(10, result);
        }
    }
}
