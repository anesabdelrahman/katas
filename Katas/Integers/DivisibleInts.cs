namespace Katas.Integers
{
    public class DivisibleInts
    {
        public int CalculateDivisibleInts(int input)
        {
            var number = input;
            var count = 0;

            while (number > 0)
            {
                number /= 10;
                if (input % number == 0)
                    count++;
            }

            return count;
        }
    }
}
// 123 >> 3
// [1,2,3,
// 12,23,123] 6

// 1230 >> 4
// [1,2,3,0,
// 12,23,30,123,
// 230,1230] 10

// 12345 >> 5
// [1,2,3,4,5,
// 12,23,34,45,123,
// 234,345,1234,2345,12345] 15
