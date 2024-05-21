namespace Katas.Integers
{
    public class Matrix
    {
        public int[][] FillMatrix(int input)
        {
            var result = new int[input][];
            for (var i = 0; i < input; i++)
                result[i] = new int[input];

            var counter = 1;
            int columnStart = 0, rowStart = 0;
            int columnEnd = input - 1, rowEnd = input - 1;

            while (rowStart <= rowEnd && columnStart <= columnEnd)
            {
                // Populate top row
                for (var i = columnStart; i <= columnEnd; i++)
                    result[rowStart][i] = counter++;

                rowStart++;

                // Populate right column
                for (var i = rowStart; i <= rowEnd; i++)
                    result[i][columnEnd] = counter++;

                columnEnd--;

                // Populate bottom row
                if (rowStart <= rowEnd)
                {
                    for (var i = columnEnd; i >= columnStart; i--)
                        result[rowEnd][i] = counter++;
                    rowEnd--;
                }


                // Populate left column
                if (columnStart <= columnEnd)
                {
                    for (var i = rowEnd; i >= rowStart; i--)
                        result[i][columnStart] = counter++;
                    columnStart++;
                }
            }

            return result;
        }
    }
}
