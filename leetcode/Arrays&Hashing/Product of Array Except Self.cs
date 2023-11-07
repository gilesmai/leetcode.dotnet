using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            Dictionary<int, int> leftProduct = new() { { 0, 1 } };
            Dictionary<int, int> rightProduct = new() { { nums.Length - 1, 1 } };
            var result = new int[nums.Length];
            int zeroCount = 0;
            int leftTemp = 1;
            int rightTemp = 1;
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount += 1;
                }
                leftTemp *= nums[i - 1];
                leftProduct[i] = leftTemp;
            }

            if (zeroCount > 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result[i] = 0;
                }
                return result;
            }
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                rightTemp *= nums[i + 1];
                rightProduct[i] = rightTemp;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = leftProduct[i] * rightProduct[i];
            }
            return result;
        }
    }
}
