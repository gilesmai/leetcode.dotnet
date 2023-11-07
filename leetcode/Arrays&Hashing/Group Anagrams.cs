using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Group_Anagrams
    {
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                Dictionary<string, IList<string>> anagrams = new Dictionary<string, IList<string>>();
                foreach (string str in strs)
                {
                    char[] chars = str.ToCharArray();
                    Array.Sort(chars);
                    string sortedStr = new String(chars);
                    if (anagrams.TryGetValue(sortedStr, out var list))
                    {
                        list.Add(str);
                    }
                    else
                    {
                        anagrams.Add(sortedStr, new List<string> { str });
                    }
                }
                return anagrams.Values.ToList();
            }
        }
    }
}
