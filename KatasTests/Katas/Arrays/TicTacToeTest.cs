using System.Collections;
using System.Linq;
using Katas.Arrays;
using NUnit.Framework;

namespace Tests.Katas.Arrays
{
    [TestFixture]
    public class TicTacToeTest
    {
        [Test]
        [TestCase(new[] { "XOX", "XXX", "OXO" }, "true")]
        [TestCase(new[] { "OXO", "XOO", "XOX" }, "tie")]
        [TestCase(new[] { "O-X", "-XO", "OOX" }, "tie")]
        [TestCase(new[] { "OXX", "XOO", "XOO" }, "tie")]
        [TestCase(new[] { "-O-", "-OX", "-O-" }, "tie")]
        public void Test(string[] input, string expected)
        {
            var sut = new TicTacToe();
            var result = sut.Solve(input);
            Assert.AreEqual(result, expected);
        }
    }

    public class TicTacToe
    {
        public string Solve(string[] input)
        {
            foreach (var item in input)
            {
                var chars = item.ToCharArray();
                if (chars.All(d => d == 'X') || chars.All(d => d == 'O'))
                    return "true";
            }

            return "tie";
        }
    }
}
