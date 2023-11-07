using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> charCout = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];
                if (!charCout.ContainsKey(charS))
                {
                    charCout[charS] = 0;
                }
                if (!charCout.ContainsKey(charT))
                {
                    charCout[charT] = 0;
                }
                charCout[charS] += 1;
                charCout[charT] -= 1;
            }
            return charCout.Values.All(x => x == 0);
        }
    }
}
