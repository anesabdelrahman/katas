using System;
using System.Text.RegularExpressions;

namespace Katas.Strings
{
    public class StringAnagram
    {
        public bool IsAnagram(string firstString, string secondString)
        {

            var firstOutput = Regex.Replace(firstString.ToLower(), "[^\\w]", "").ToCharArray();
            var secondOutput = Regex.Replace(secondString.ToLower(), "[^\\w]", "").ToCharArray();
            Array.Sort(firstOutput);
            Array.Sort(secondOutput);
            return string.Join(' ', firstOutput) == string.Join(' ', secondOutput);
        }
    }
}
