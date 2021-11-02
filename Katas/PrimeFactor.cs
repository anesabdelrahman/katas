﻿using System;
using System.Collections.Generic;

namespace Katas
{
    public class PrimeFactor
    {
        public IList<int> GetPrimeFactors(int number)
        {
            var factors = new List<int>();
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                for (; number % divisor == 0; number /= divisor)
                {
                    factors.Add(divisor);
                }
            }

            if (number > 1)
            {
                factors.Add(number);
            }
            return factors;
        }
    }
}
