using System.Collections.Generic;

namespace Katas
{
    public class Fibonacci
    {
        public int Calculate(int input)
        {
            var result = new List<int>();
            for (var i = 0; i <= input; i++)
            {
                if (i < 2)
                {
                    result.Add(i);
                    continue;
                }
                var first = result[i - 2];
                var second = result[i - 1];
                result.Add(first + second);
            }
            return result[input];
        }
    }
}
