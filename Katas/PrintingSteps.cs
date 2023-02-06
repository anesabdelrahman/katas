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
                var current = string.Concat(new string('#', i), new string(' ', steps - i));
                Console.WriteLine(current);
            }
        }
    }
}
