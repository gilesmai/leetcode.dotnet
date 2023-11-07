using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> indexDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (indexDict.TryGetValue(target - nums[i], out int index2))
                {
                    return new int[] { i, index2 };
                }
                else
                {
                    indexDict[nums[i]] = i;
                }
            }
            return new int[0];
        }
    }
}
