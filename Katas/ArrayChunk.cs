using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class ArrayChunk
    {
        public List<List<int>> Chunk(int[] input, int size)
        {
            var result = new List<List<int>>();
            var index = 0;

            while (index < input.Length)
            {
                var current = input.ToList().Skip(index).Take(size).ToList();
                result.Add(current);
                index += size;
            }

            

            return result;
        }
    }
}
