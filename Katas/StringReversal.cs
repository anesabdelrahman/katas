using System.Linq;
using System.Text;

namespace Katas
{
    public class StringReversal
    {
        public string Reverse(string input)
        {
            var result = new StringBuilder();
            input.ToList().ForEach(x => result.Insert(0, x));
            return result.ToString();
        }
    }
}
