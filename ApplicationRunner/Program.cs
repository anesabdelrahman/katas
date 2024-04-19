using System;

namespace ApplicationRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //var hash = SecurityUtility.EncodePassword("ouEQZx6VbaljTS7X6SoIQ0GQk");
            //var security1 = SecurityUtility.VerifyPasswordHash(hash, "ouEQZx6VbaljTS7X6SoIQ0GQk");
            Console.ReadLine();
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

    class TestingReadOnly
    {
        public readonly int VERSION = 5;
        public TestingReadOnly()
        {
            //VERSION = 6;
        }
    }
}
