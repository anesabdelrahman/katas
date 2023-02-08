using System;

namespace Katas
{
    public class PrintingPyramid
    {
        public void Print(int steps)
        {
            for (var i = 1; i <= steps; i++)
            {
                var current = string.Concat(new string(' ', steps - i), new string('#', i*2-1), new string(' ', steps - i));
                Console.WriteLine(current);
            }
        }
    }
}
