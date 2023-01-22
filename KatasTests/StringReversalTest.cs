using System;
using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class StringReversalTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase()]
        public void Test()
        {
            var result = new StringReversal().Reverse("anes");
            Assert.AreEqual("sena", result);
        }
    }
}
