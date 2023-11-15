public class VP
{
    public bool IsPalindrome(string s)
    {
        var onlyAlphanumeric = s.ToLower().ToList().Where(c => char.IsLetterOrDigit(c)).ToArray();
        return Enumerable.SequenceEqual(onlyAlphanumeric, onlyAlphanumeric.Reverse());
    }

    //use two pointers
    public bool IsPalindrome1(string s)
    {
        int start = 0;
        int end = s.Length - 1;
        while (start < end)
        {
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
                continue;
            }

            if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
            {
                return false;
            }
            else
            {
                start++;
                end--;
            }
        }
        return true;
    }
}