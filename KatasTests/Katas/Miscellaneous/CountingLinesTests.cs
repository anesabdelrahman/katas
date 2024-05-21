using Katas;
using Katas.Miscellaneous;
using NUnit.Framework;

namespace Tests.Katas.Miscellaneous
{
    [TestFixture]
    public class CountingLinesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sut = new CountingLines();
            var result = sut.CountLines();
            var expectedResult = "There are 3 lines of code for: .\\Files/TextFile1.txt\r\nThere are 5 lines of code for: .\\Files/TextFile2.txt\r\n";
            Assert.AreEqual(result, expectedResult);
        }
    }
}
