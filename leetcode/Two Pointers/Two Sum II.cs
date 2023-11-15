public class TwoSumII
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int start = 0;
        int end = numbers.Length - 1;
        while (start < end)
        {
            if (numbers[start] + numbers[end] < target)
            {
                start++;
            }
            else if (numbers[start] + numbers[end] > target)
            {
                end--;
            }
            else
            {
                return new int[] { start + 1, end + 1 };
            }
        }
        return new int[2];
    }
}