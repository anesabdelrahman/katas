using System.Linq;

namespace Tests.Katas;

public class ArrayElements
{
    public int[] CalculateProductOfElements(int[] array)
    {
        var totalProduct = 1;
        var arrayList = array.ToList();

        if (arrayList.All(i => i == 0))
            return array;

        var noneZeroList = arrayList.Where(i => i != 0).ToList();

        noneZeroList.ForEach(i => totalProduct *= i);

        var hasZero = arrayList.Any(i => i == 0);

        for (var i = 0; i < array.Length; i++)
        {
            if (hasZero)
            {
                array[i] = array[i] == 0 ? totalProduct : 0;
                continue;
            }
            array[i] = totalProduct / array[i];
        }

        return array;
    }
}
