using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public class Day1
    {
        public int CalculateCodes(string inputFile)
        {
            var charList = new List<char>(inputFile);
            var numbersFound = new List<int>();
            foreach (var item in charList)
            {
                if (char.IsDigit(item))
                {
                    numbersFound.Add((int)char.GetNumericValue(item));
                }
            }
            return numbersFound.FirstOrDefault() + numbersFound.LastOrDefault();
        }

        public int ReadFileContents(string inputFile)
        {
           var inputContent = File.ReadAllLines(inputFile).ToList();
           var result = 0;
           foreach (var line in inputContent)
           {
               result += CalculateCodes(line);
           }
           // return result
           return result;
        }
    }
}
