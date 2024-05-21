using System.Linq;
using System.Text;

namespace Katas.Strings
{
    public class FizzBuzz
    {
        public string GenerateFizzBuzz()
        {
            var output = new StringBuilder();
            var collection = Enumerable.Range(1, 100);


            foreach (var i in collection)
            {
                var result = i % 15 == 0 ?
                "FizzBuzz" :
                i % 3 == 0 ?
                "Fizz" :
                i % 5 == 0 ?
                "Buzz" :
                i.ToString();

                output.AppendLine(result);
            }

            return output.ToString();
        }
    }
}
