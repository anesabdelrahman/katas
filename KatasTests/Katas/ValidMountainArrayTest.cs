using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class ValidMountainArrayTest
    {
        [Test]
        [TestCase(new int[] { 3, 2 }, false )]
        [TestCase(new int[] { 3, 2, 8 }, false )]
        [TestCase(new int[] { 3, 2, 0 }, false )]
        [TestCase(new int[] { 3, 5, 0 }, true )]
        [TestCase(new int[] { 9,8,7,6,5,4,3, 2,1, 0 }, false )]
        [TestCase(new int[] { 0,1,2,3,4,5,6,7,8,9 }, false )]
        [TestCase(new int[] { 0, 3, 2, 1 }, true )]
        [TestCase(new int[] { 0, 3, 2, 8 }, false )]
        [TestCase(new int[] { 0,1,2,3,4, 4 ,5,6,7,8,9 }, false )]
        public void Test_Initial_Implementaion(int[] arr, bool expectedResult)
        {
            var sut = new ValidMountainArray();
            var result = sut.ValidMountain_Initial(arr);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase(new int[] { 3, 2 }, false)]
        [TestCase(new int[] { 3, 2, 8 }, false)]
        [TestCase(new int[] { 3, 2, 0 }, false)]
        [TestCase(new int[] { 3, 5, 0 }, true)]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, false)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, false)]
        [TestCase(new int[] { 0, 3, 2, 1 }, true)]
        [TestCase(new int[] { 0, 3, 2, 8 }, false)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 4, 5, 6, 7, 8, 9 }, false)]
        public void Test_Modified_Implementaion(int[] arr, bool expectedResult)
        {
            var sut = new ValidMountainArray();
            var result = sut.ValidMountain_Modified(arr);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
