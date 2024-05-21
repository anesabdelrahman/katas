using System.Linq;
using System.Text;

namespace Katas.Strings
{
    public class Palindrome
    {
        public bool IsPalindrome(string input)
        {
            var result = new StringBuilder();
            input.ToList().ForEach(x => result.Insert(0, x));
            return input == result.ToString();
        }
    }
}
