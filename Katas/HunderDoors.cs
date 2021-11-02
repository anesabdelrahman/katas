using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class HunderdDoors
    {
        public string GetHunderdDoors()
        {
            var doors = Enumerable.Repeat("Closed", 100).ToArray();
            var result = new StringBuilder();

            foreach (var pass in Enumerable.Range(0, 100))
            {
                foreach (var index in Enumerable.Range(0, 100))
                {

                    if (doors[index] == "Closed")
                    {
                        doors[index] = "Open";
                    }
                    else
                    {
                        doors[index] = "Closed";
                    }
                result.AppendLine($"Pass: {pass+1}, Door: {index+1}, State: {doors[index]}");
                }
            }

            return result.ToString();
        }
    }
}
