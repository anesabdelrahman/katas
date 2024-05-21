using System.Linq;

namespace Katas.Strings
{
    public class CapitalizeFirstChar
    {
        public string Capitalize(string input)
        {
            input.Split(' ');
            var result = input.Split(' ').Select(item => item[0].ToString().ToUpper() + item[1..]);

            return string.Join(" ", result);
        }
    }
}
