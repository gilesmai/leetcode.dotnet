public class ThreeSums
{
    // public IList<IList<int>> ThreeSum(int[] nums)
    // {
    //     IEnumerable<IList<int>> result = new List<IList<int>>();
    //     Array.Sort(nums);
    //     int n = nums.Length - 1;
    //     for (int i = 0; i <= n - 2; i++)
    //     {
    //         if (nums[i] > 0)
    //         {
    //             break;
    //         }
    //         int start = i + 1;
    //         if (i != 0 && nums[i - 1] == nums[i])
    //         {
    //             continue;
    //         }
    //         var rest = TwoSum(nums[start..], 0 - nums[i], nums[i]);
    //         result = result.Concat(rest);
    //     }
    //     return result.ToList();
    // }
    // public List<List<int>> TwoSum(int[] nums, int target, int first)
    // {
    //     HashSet<int> lookUp = new();
    //     List<List<int>> result = new();
    //     for (int i = 0; i <= nums.Length - 1; i++)
    //     {
    //         if ((i == nums.Length - 1 || nums[i] != nums[i + 1]) && lookUp.Contains(target - nums[i]))
    //         {
    //             result.Add(new List<int> { first, target - nums[i], nums[i] });
    //         }
    //         lookUp.Add(nums[i]);
    //     }
    //     return result;
    // }

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        int n = nums.Length - 1;
        for (int i = 0; i <= n - 2; i++)
        {
            if (nums[i] > 0)
            {
                break;
            }
            if (i != 0 && nums[i - 1] == nums[i])
            {
                continue;
            }

            int start = i + 1;
            int end = n;
            int target = 0 - nums[i];
            while (start < end)
            {
                if (nums[start] + nums[end] < target)
                {
                    start += 1;
                }
                else if (nums[start] + nums[end] > target)
                {
                    end -= 1;
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[start], nums[end] });
                    do
                    {
                        start += 1;
                    } while (start < n && nums[start - 1] == nums[start]);
                    do
                    {
                        end -= 1;
                    }
                    while (end > 0 && nums[end + 1] == nums[end]);
                }
            }
        }
        return result.ToList();
    }
}