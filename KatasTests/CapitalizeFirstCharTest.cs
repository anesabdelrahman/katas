using System;
using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class CapitalizeFirstCharTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("hi there, how is it going?", "Hi There, How Is It Going?")]
        [TestCase("i love breakfast at bill miller bbq", "I Love Breakfast At Bill Miller Bbq")]
        
        public void Test(string inputString, string expected)
        {
            var result = new CapitalizeFirstChar().Capitalize(inputString);
            Assert.AreEqual(expected, result);
        }
    }
}
