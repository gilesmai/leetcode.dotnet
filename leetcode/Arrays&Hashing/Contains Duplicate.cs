using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            return set.Count != nums.Count();
        }
    }
}
