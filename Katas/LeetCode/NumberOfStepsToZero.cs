namespace Katas.LeetCode
{
    public class NumberOfStepsToZero
    {
        public int NumberOfSteps(int num)
        {
            var counter = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num -= 1;
                }
                counter++;
            }

            return counter;
        }
    }
}
