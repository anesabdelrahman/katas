using Katas;
using Katas.Integers;
using NUnit.Framework;

namespace Tests.Katas.Integers
{
    [TestFixture]
    public class IntReversalTest
    {
        [Test]
        //[TestCase(51, 15)]
        //[TestCase(987, 789)]
        //[TestCase(105, 501)]
        [TestCase(-35, -53)]
        public void Test(int input, int expected)
        {
            var result = new IntReversal().Reverse(input);
            Assert.AreEqual(expected, result);
        }
    }
}
