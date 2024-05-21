using System.Collections.Generic;
using System.Text;

namespace Katas.Strings
{
    public class RomanNumeral
    {
        public readonly Dictionary<string, string> romanMap = new Dictionary<string, string>
            {
                { "1", "I" },
                { "2", "II" },
                { "3", "III" },
                { "4", "IV" },
                { "5", "V" },
                { "6", "VI" },
                { "7", "VII" },
                { "8", "VIII" },
                { "9", "IX" },
                { "10", "X" },
                { "20", "XX" },
                { "30", "XXX" },
                { "40", "XL" },
                { "50", "L" },
                { "60", "LX" },
                { "70", "LXX" },
                { "80", "LXXX" },
                { "90", "XC" },
                { "100", "C" },
                { "200", "CC" },
                { "300", "CC" },
                { "400", "CD" },
                { "500", "D" },
                { "600", "DC" },
                { "700", "DCC" },
                { "800", "DCCC" },
                { "900", "CM" },
                { "1000", "M" },
                { "2000", "MM" },
                { "3000", "MMM" },
                { "4000", "MMMM" }
            };

        public string GetRomanNumeral(string numberString)
        {
            var result = new StringBuilder();

            for (var i = 0; i < numberString.Length; i++)
            {
                if (numberString[i] == '0') continue;
                var key = string.Empty;
                key = numberString[i] + key.PadRight(numberString.Length - 1 - i, '0');
                result.Append(romanMap[key]);
            }


            return result.ToString();

        }
    }
}
