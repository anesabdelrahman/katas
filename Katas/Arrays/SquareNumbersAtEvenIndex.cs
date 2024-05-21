namespace Katas.Arrays;

public class SquareNumbersAtEvenIndex
{
    public int[] SequareEvenIndex(int[] input)
    {
        for (var i = 0; i < input.Length; i += 2)
            input[i] *= input[i];
        return input;
    }
}
