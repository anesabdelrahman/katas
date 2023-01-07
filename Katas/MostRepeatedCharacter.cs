using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public static class MostRepeatedCharacter
    {
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new Tuple<char?, int>(null, 0);

            const string pattern = @"(\w)\1*";
            var expression = new Regex(pattern);
            var matches = expression.Matches(input);
            var result = matches.Where(i => i.Value.Length == matches.Max(x => x.Value.Length)).ToList();

            return new Tuple<char?, int>(result.FirstOrDefault()?.Value.First(), result.FirstOrDefault().Value.Length);
        }

        public static Tuple<char?, int> LongestRepetitionTwo(string input)
            => input
                .Select((x, i) => new Tuple<char?, int>(x, input.Substring(i).TakeWhile(y => y == x).Count()))
                .OrderByDescending(x => x.Item2)
                .FirstOrDefault()
               ?? new Tuple<char?, int>(null, 0);
    }
}
