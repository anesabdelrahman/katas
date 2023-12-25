using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class MatchingSocks
    {
        public int GetMatchingSocks(int n, List<int> colourArray)
        {

            int result = 0;
            var groups = from colour in colourArray
                         group colour by new { SockColour = colour } into newGroup
                         select newGroup;


            foreach (var item in groups)
            {
                result += (int)(item.Count() / 2);
            }

            return result;
        }
    }
}
