using System;
using System.Collections;
using System.Linq;

namespace Katas
{
    public class ArrayShuffle
    {
        public IEnumerable ShuffleArray(int lower, int upper)
        {
            var numbers = Enumerable.Range(lower, upper - 1);
            var random = new Random();
            numbers = numbers.OrderBy(x => random.Next()).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            return numbers;
        }
    }
}
