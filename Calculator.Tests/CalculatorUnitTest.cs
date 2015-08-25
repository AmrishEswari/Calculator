using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Calculator.Tests
{
 
     [TestFixture]
    public class CalculatorUnitTest
    {
        [TestCase]
        public void Add()
        {
            Calculator.Form1 test = new Calculator.Form1();
            int result = test.result(20, 30);
            Assert.AreEqual(50, result);
        }
    }
}

