public class GP
{
    public IList<string> GenerateParenthesis(int n)
    {
        //two conditions:
        //1. open + close == n
        //2. In each loop, close must less or equal than open
        List<string> result = new List<string>();

        void calParenthesis(string current, int open, int close, int n)
        {
            if (open == n && close == n)
            {
                result.Add(current);
            }

            if (open > close)
            {
                calParenthesis(current + ")", open, close + 1, n);
            }

            if (open < n)
            {
                calParenthesis(current + "(", open + 1, close, n);
            }
        }
        calParenthesis("", 0, 0, n);

        return result;
    }

}