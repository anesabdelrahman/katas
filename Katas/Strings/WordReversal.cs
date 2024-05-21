using System.Linq;

namespace Tests.Katas;

public class WordReversal
{
    public string Reverse(string input)
    {
        var words = input.Split(' ');
        var reversed = words.Reverse();
        return string.Join(' ', reversed);
    }
}
