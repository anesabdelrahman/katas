using System.Collections.Generic;

namespace Katas.Strings
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var magazineLetters = new Dictionary<char, int>();
            foreach (var m in magazine)
                if (magazineLetters.ContainsKey(m))
                    magazineLetters[m]++;
                else
                    magazineLetters.Add(m, 1);

            foreach (var r in ransomNote)
                if (magazineLetters.TryGetValue(r, out var count))
                    if (count > 0)
                        magazineLetters[r]--;
                    else
                        return false;
                else
                    return false;
            return true;
        }
    }
}
