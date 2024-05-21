using System;
using System.Collections.Generic;

namespace Katas.Integers
{
    public class PrimeFactor
    {
        public IList<int> GetPrimeFactors(int number)
        {
            var factors = new List<int>();
            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                for (; number % divisor == 0; number /= divisor)
                    factors.Add(divisor);

            if (number > 1)
                factors.Add(number);
            return factors;
        }
    }
}
