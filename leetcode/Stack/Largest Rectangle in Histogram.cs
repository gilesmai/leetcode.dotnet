public class LRH
{
    public int LargestRectangleArea(int[] heights)
    {
        //for each bar, the largest rectangle is
        // (previous lesser bar + 1 + next lesser bar) * height

        int[] pre = new int[heights.Length];
        int[] next = new int[heights.Length];
        for (int i = 0; i < heights.Length; i++)
        {
            pre[i] = i;
            next[i] = heights.Length - i - 1;
        }

        Stack<int> stack = new();
        for (int i = 0; i < heights.Length; i++)
        {
            while (stack.Count != 0 && heights[i] < heights[stack.Peek()])
            {
                var index = stack.Pop();
                next[index] = i - index - 1;
            }

            stack.Push(i);
        }

        stack.Clear();
        for (int i = heights.Length - 1; i >= 0; i--)
        {
            while (stack.Count != 0 && heights[i] < heights[stack.Peek()])
            {
                var index = stack.Pop();
                pre[index] = index - i - 1;
            }

            stack.Push(i);
        }

        int maxRect = int.MinValue;
        for (int i = 0; i < heights.Length; i++)
        {
            int size = (pre[i] + 1 + next[i]) * heights[i];
            maxRect = Math.Max(maxRect, size);
        }

        return maxRect;
    }

    public int LargestRectangleAreaOptimal(int[] heights)
    {
        //for each bar, the largest rectangle is
        // (next lesser bar index - previous less bar index - 1) * height


        Stack<int> stack = new();
        int maxRect = int.MinValue;
        for (int i = 0; i < heights.Length; i++)
        {
            while (stack.Count != 0 && heights[i] < heights[stack.Peek()])
            {
                var index = stack.Pop();
                var rightIndex = i;
                var leftIndex = stack.Count == 0 ? -1 : stack.Peek();
                maxRect = Math.Max(maxRect, (rightIndex - leftIndex - 1) * heights[index]);
            }
            stack.Push(i);
        }
        var lastIndex = stack.Peek();
        while (stack.TryPop(out int index))
        {
            var rightIndex = lastIndex + 1;
            var leftIndex = stack.Count == 0 ? -1 : stack.Peek();
            maxRect = Math.Max(maxRect, (rightIndex - leftIndex - 1) * heights[index]);
        }

        return maxRect;
    }
}