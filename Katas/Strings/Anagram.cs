using System.Collections.Generic;
using System.Linq;

namespace Katas.Strings
{
    public class Anagram
    {
        public bool IsAnagramUsingLists(string first, string second)
        {
            if (first.Length != second.Length) return false;
            var firstLetters = first.OrderBy(x => x).ToList();
            var secondLetters = second.OrderBy(x => x).ToList();

            return firstLetters.SequenceEqual(secondLetters);
        }


        public bool IsAnagramUsingDictionary(string first, string second)
        {
            if (first.Length != second.Length) return false;
            var charList = new Dictionary<char, int>();
            foreach (var character in first)
                if (charList.ContainsKey(character))
                    charList[character]++;
                else
                    charList[character] = 1;

            foreach (var character in second)
            {
                if (!charList.ContainsKey(character))
                    return false;

                charList[character]--;
                if (charList[character] < 0)
                    return false;
            }

            return charList.Values.All(value => value == 0);
        }
    }
}
