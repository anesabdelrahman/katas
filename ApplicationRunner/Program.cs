using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Katas;

namespace ApplicationRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fizzBuzzApp = new FizzBuzz();
            //var result = fizzBuzzApp.GenerateFizzBuzz();

            //Console.WriteLine(result);

            //var array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //var slice = new Span<int>(array, 2, 5);
            //for (int ctr = 0; ctr < slice.Length; ctr++)
            //    slice[ctr] *= 2;

            //// Examine the original array values.
            //foreach (var value in slice)
            //    Console.Write($"{value}  ");
            //Console.WriteLine();
            //Console.Read();

            //string text = "The the quick brown fox fox jumps over the lazy dog dog";
            //var repeatedWords = new Dictionary<string, int>();
            //var wordsCollection = text.ToLower().Split(' ');

            //for (int i = 0; i < wordsCollection.Length; i++)
            //{
            //    if (repeatedWords.ContainsKey(wordsCollection[i].ToLower()))
            //    {
            //        repeatedWords[wordsCollection[i]] += 1;
            //    }
            //    else
            //    {
            //        repeatedWords.Add(wordsCollection[i], 1);
            //    }
            //}

            //foreach (var word in repeatedWords)
            //{
            //    Console.WriteLine($"The word {word.Key} showed {word.Value} times in text");
            //}


            //txt.spl

            //var lowNums = numbers.Where(x => x > 5).Where(y => y % 2 == 0).Max();

            string x = "1,2,3";

            var result = x.Split(',').Sum(i => int.Parse(i));


            Console.WriteLine($"result {result} ");

            //foreach (var x in lowNums)

            //{

            //    Console.WriteLine(x);

            //}

            Console.ReadLine();



            //string text = "ddddddsx";
            //var repeatedWords = new Dictionary<string, int>();
            //var wordsCollection = text.ToLower().Split(' ');




            //Console.WriteLine("Most repeated is  '{0}'", GetMostRepeatedCharacter(text));


            //Console.Read();
        }

        private static char GetMostRepeatedCharacter(string input)
        {
            var charCount = new int[256];
            var max = 0;
            char result = char.MinValue;

            foreach (var item in input)
            {
                if (item != ' ' && ++charCount[item] > max)
                {
                    max = charCount[item];
                    result = item;

                }
            }



            return result;
        }
    }
}
