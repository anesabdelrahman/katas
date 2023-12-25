using System.Linq;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class ProductOfArrayElements
    {
        [Test]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        [TestCase(new[] { 1, 0, 3, 4 }, new[] { 0, 12, 0, 0 })]
        [TestCase(new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 })]
        [TestCase(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
        public void CalculateProductOfArrayElements(int[] input, int[] expected)
        {
            var result = new ArrayElements().CalculateProductOfElements(input);
            Assert.AreEqual(expected, result);
        }
    }

    public class ArrayElements
    {
        public int[] CalculateProductOfElements(int[] array)
        {
            var totalProduct = 1;
            var arrayList = array.ToList();

            if (arrayList.All(i => i == 0))
                return array;

            var noneZeroList = arrayList.Where(i => i != 0).ToList();

            noneZeroList.ForEach(i => totalProduct *= i);

            var hasZero = arrayList.Any(i => i == 0);

            for (var i = 0; i < array.Length; i++)
            {
                if (hasZero)
                {
                    array[i] = array[i] == 0 ? totalProduct : 0;
                    continue;
                }
                array[i] = totalProduct / array[i];
            }

            return array;
        }
    }
}
