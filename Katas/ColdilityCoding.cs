using System.Linq;
using System.Numerics;
using System.Text;

namespace Katas;

public class ColdilityCoding
{
    public int ParseToBigInt(string S)
    {
        var steps = 0;
        
        BigInteger intValue = S
            .Aggregate(BigInteger.Zero, (s, a) => (s << 1) + a - '0');

        while (intValue > 0)
        {
            if ((intValue % 2) == 0)
            {
                intValue /= 2;
            }
            else
            {
                intValue -= 1;
            }
            steps++;
        }

        return steps;
    }

    public int CheckAndChangeChars(string S)
    {
        /*
         * 10 >> 1
         * 1000 >> 100
         * 1010 >> 101
         * So, when even and dividing by 2, we shift to the right
         *
         *
         * 1 >> 0
         * 101 >> 100
         * 1001 >> 1000 
         * so when odd and subtract one, we change the right most 1 to zero.
         *
         */

        //0110
        S = S.TrimStart('0');
        var steps = 0;

        while (S != "0" || S.Length >  1)
        {
          
            S = S.EndsWith('0') ? HandleEven(S) : HandleOdd(S);
            steps++;
        }

        return steps;
    }

    private string HandleEven(string S)
    {
        return S.Remove(S.Length - 1);
    }
    
    private string HandleOdd(string S)
    {
        var sb = new StringBuilder(S) {[S.Length - 1] = '0'};
        return sb.ToString();
    }
}
