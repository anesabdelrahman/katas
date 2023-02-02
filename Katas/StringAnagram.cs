using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class StringAnagram
    {
        public bool IsAnagram(string firstString, string secondString)
        {

            var firstOutput =  Regex.Replace(firstString.ToLower(), "[^\\w]", "").ToCharArray();
            var secondOutput = Regex.Replace(secondString.ToLower(), "[^\\w]", "").ToCharArray();
            //Console.WriteLine(firs);
            Array.Sort(firstOutput);
            Array.Sort(secondOutput);
            return string.Join( ' ', firstOutput) == string.Join(' ', secondOutput);
        }
    }
}
