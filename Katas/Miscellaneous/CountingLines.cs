using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas.Miscellaneous
{
    public class CountingLines
    {
        public string CountLines()
        {
            var result = new StringBuilder();
            var fileList = new List<string> {".\\Files/TextFile2.txt"};//, ".\\Files/TextFile2.txt" };

            try
            {
                fileList.ForEach(file =>
                    result.AppendLine($"There are {CountCodeLines_Regex(File.ReadAllLines(file))} lines of code for: {file}"));
                return result.ToString();
            }
            catch
            (Exception exception)
            {
                return $"Failed to load or read files: Error: {exception.Message}";
            }
        }

        int CountCodeLines_Trim(IEnumerable<string> fileLines)
        {
            return fileLines.Count(line =>
                !string.IsNullOrWhiteSpace(line) &&
                !line.TrimStart().StartsWith('/') &&
                !line.TrimStart().StartsWith('*'));
        }
        int CountCodeLines_Regex(IEnumerable<string> fileLines)
        {
            var regex = new Regex(@"^\s*(\/|\*|\s$)gm");

            // Count lines that do not match the regex (i.e., lines that have content)
            return fileLines.Count(line => !regex.IsMatch(line.TrimStart()));
        }
    }
}
