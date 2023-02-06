using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class PrintingSteps
    {
        public void Print(int steps)
        {
            for (var i = 1; i <= steps; i++)
            {
                var str1 = new string('#', i);
                var str2 = new string(' ', steps-i);

                var current = string.Concat(str1, str2);
                Console.WriteLine(current);
            }
        }
    }
}
