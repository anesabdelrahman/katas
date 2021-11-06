using System;
using System.Collections.Generic;

namespace Katas
{
    public class Calculator
    {
        public List<char> delimiters = new List<char>() { ',', '\n', ';' };

        public int Add(string numbersAsString)
        {
            var result = 0;
            if (numbersAsString == string.Empty)
            {
                return result;
            }

            if (numbersAsString.StartsWith("//"))
            {
                delimiters.Add(numbersAsString[2]);
                numbersAsString = numbersAsString.Substring(2);
            }

            foreach (string digit in numbersAsString.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                result += Convert.ToInt16(digit);
            }
            return result;
        }
    }
}
