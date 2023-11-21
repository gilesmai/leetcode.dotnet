public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = int.MinValue;
        while (left < right)
        {
            int leftHeight = height[left];
            int rightHeight = height[right];
            maxArea = Math.Max(Math.Min(leftHeight, rightHeight) * (right - left), maxArea);
            if (leftHeight < rightHeight)
            {
                left += 1;
            }
            else
            {
                right -= 1;
            }
        }
        return maxArea;
    }
}