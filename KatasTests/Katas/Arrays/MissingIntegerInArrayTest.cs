﻿using Katas;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class MissingIntegerInArrayTest
    {
        [Test]
        [TestCase(new[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [TestCase(new[] { -1, -3 }, 1)]
        public void CalculatePathCost(int[] input, int expected)
        {
            var result = new MissingIntegerInArray().CalculateMissingInteger(input);
            Assert.AreEqual(expected, result);
        }
    }
}
