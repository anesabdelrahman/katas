using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Katas
{
    public class CountingLines
    {
        public string CountLines()
        {
            var result = new StringBuilder();
            var fileList = new List<string> { ".\\Files/TextFile1.txt", ".\\Files/TextFile2.txt" };

            try
            {
                fileList.ForEach(file =>
                    result.AppendLine($"There are {CountCodeLines(File.ReadAllLines(file))} lines of code for: {file}"));
                return result.ToString();
            }
            catch
            (Exception exception)
            {
                return ($"Failed to load or read files: Error: {exception.Message}");
            }
        }

        int CountCodeLines(IEnumerable<string> fileLines)
        {
            return fileLines.Count(line =>
                !string.IsNullOrWhiteSpace(line) &&
                !line.TrimStart().StartsWith('/') &&
                !line.TrimStart().StartsWith('*'));
        }
    }
}
