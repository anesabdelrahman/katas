using System.Text.RegularExpressions;

namespace Katas
{
    public class Vowels
    {
        public int CountVowels(string input)
        {
            var match = Regex.Matches(input, "[aeiou]", RegexOptions.IgnoreCase);
            return match.Count;

            
        }
    }
}
// One Solution
//var result = 0;
//var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

//foreach (var vowel in input.ToLower())
//{
//    if (vowels.Contains(vowel))
//    {
//        result++;
//    }
//}

//return result;
