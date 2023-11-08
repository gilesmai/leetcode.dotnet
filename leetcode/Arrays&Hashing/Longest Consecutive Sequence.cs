using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Longest_Consecutive_Sequence
    {
        //Hashing
        //public int LongestConsecutive(int[] nums)
        //{
        //    var hashNums = new HashSet<int>(nums);
        //    int longestConsecutive = 0;
        //    foreach (int i in hashNums)
        //    {
        //        if (!hashNums.Contains(i - 1))
        //        {
        //            int temp = i + 1;
        //            while (hashNums.Contains(temp))
        //            {
        //                temp += 1;
        //            }
        //            longestConsecutive = Math.Max(longestConsecutive, temp - i);
        //            if (longestConsecutive > hashNums.Count / 2)
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    return longestConsecutive;
        //}

        //DP
        public int LongestConsecutive(int[] nums)
        {
            int DP(int num, Dictionary<int, int> lookUp)
            {
                if (!lookUp.ContainsKey(num))
                {
                    return 0;
                }
                if (lookUp[num] != 0)
                {
                    return lookUp[num];
                }
                lookUp[num] = 1 + DP(num + 1, lookUp);
                return lookUp[num];
            }
            Dictionary<int, int> lookUp = new HashSet<int>(nums).ToDictionary(x => x, x => 0);
            foreach (int num in lookUp.Keys)
            {
                DP(num, lookUp);
            }
            return lookUp.Values.Count > 0 ? lookUp.Values.Max() : 0;
        }
    }
}
