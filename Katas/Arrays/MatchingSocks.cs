using System.Collections.Generic;
using System.Linq;

namespace Katas.Arrays
{
    public class MatchingSocks
    {
        public int GetMatchingSocks(int n, List<int> colourArray)
        {

            var result = 0;
            var groups = from colour in colourArray
                         group colour by new { SockColour = colour } into newGroup
                         select newGroup;


            foreach (var item in groups)
                result += item.Count() / 2;

            return result;
        }
    }
}
