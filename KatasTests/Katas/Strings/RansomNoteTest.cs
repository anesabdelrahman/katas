using Katas;
using Katas.Strings;
using NUnit.Framework;

namespace Tests.Katas.Strings
{
    public class RansomNoteTest
    {
        [Test]
        [TestCase("a", "b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        public void Test(string note, string magazine, bool expectedOutput)
        {
            var ransomNote = new RansomNote();
            var result = ransomNote.CanConstruct(note, magazine);
            Assert.AreEqual(result, expectedOutput);
        }
    }
}
