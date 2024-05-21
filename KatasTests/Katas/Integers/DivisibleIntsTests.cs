using Katas;
using Katas.Integers;
using NUnit.Framework;

namespace Tests.Katas.Integers
{
    [TestFixture]
    public class DivisibleIntsTests
    {
        [Test]
        [TestCase(123, 2)]
        public void TestOne(int input, int expected)
        {
            var result = new DivisibleInts().CalculateDivisibleInts(input);
            Assert.AreEqual(expected, result);
        }
    }
}
