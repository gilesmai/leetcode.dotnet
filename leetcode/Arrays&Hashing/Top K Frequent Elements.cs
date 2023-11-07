using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Top_K_Frequent_Elements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (numCount.ContainsKey(num))
                {
                    numCount[num] += 1;
                }
                else
                {
                    numCount.Add(num, 1);
                }
            }

            return numCount.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();


        }
    }
}
