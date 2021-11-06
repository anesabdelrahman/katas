using System;
using Katas;
using NUnit.Framework;

namespace KatasTests
{
    public class CalculatorTests
    {
        [Test]
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
        [TestCase("//`\n1`2", 3)]
        public void Test(string input, int expectedOutput)
        {
            var calculator = new Calculator();
            var result = calculator.Add(input);

            Assert.AreEqual(result, expectedOutput);
        }
    }
}
