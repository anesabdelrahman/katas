using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Arrays
{
    public class TwelveDaysToChristmas
    {
        public readonly Dictionary<string, string> DaysAndLyrics = new Dictionary<string, string>()
            {
                { "first", "A partridge in a pear tree." },
                { "second", "Two turtle doves and" },
                { "third", "Three french hens" },
                { "fourth", "Four calling birds" },
                { "fifth", "Five golden rings" },
                { "sixth", "Six geese a - laying" },
                { "seventh", "Seven swans a - swimming" },
                { "eight", "Eight maids a - milking" },
                { "ninth", "Nine ladies dancing" },
                { "tenth", "Ten lords a - leaping" },
                { "eleventh", "Eleven pipers piping" },
                { "twelveth", "Twelve drummers drumming" },
            };

        public string GetCarolLyrics()
        {
            var result = new StringBuilder();
            var lastRun = false;

            foreach (var index in Enumerable.Range(0, 12))
            {
                result.AppendLine($"On the {DaysAndLyrics.ElementAt(index).Key} day of Christmas," +
                                   "\nMy true love gave to me:");

                var indexCopy = index;
                lastRun = index == 12;
                while (indexCopy >= 0)
                {
                    if (indexCopy == 0 && lastRun)
                        result.AppendLine($"And {DaysAndLyrics.ElementAt(indexCopy).Value}");

                    result.AppendLine($"{DaysAndLyrics.ElementAt(indexCopy).Value}");
                    indexCopy--;
                }
                result.AppendLine();
            }


            return result.ToString();
        }
    }
}
