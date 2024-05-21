using System;
using System.Linq;
using System.Text;

namespace Katas.Integers
{
    public class IntReversal
    {
        public int Reverse(int input)
        {
            var resultString = new StringBuilder();
            input.ToString().ToList().ForEach(x => resultString.Insert(0, x));
            var result = int.Parse(resultString.ToString().Replace('-', ' '));
            return result * Math.Sign(input);
        }
    }
}
