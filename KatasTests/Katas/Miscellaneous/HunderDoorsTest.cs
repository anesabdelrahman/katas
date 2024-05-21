using Katas;
using Katas.Miscellaneous;
using NUnit.Framework;

namespace Tests.Katas.Miscellaneous
{
    [TestFixture]
    public class HunderDoorsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            var sut = new HunderdDoors();
            var result = sut.GetHunderdDoors();
            TestContext.WriteLine($"result: {result}");
            Assert.NotNull(result);
        }
    }
}
