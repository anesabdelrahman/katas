using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sut = new FizzBuzz();
            var result = sut.GenerateFizzBuzz();
            var expectedResult = "Fizz1";
            Assert.AreEqual(result, expectedResult);
        }
    }
}
