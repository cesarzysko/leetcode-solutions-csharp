namespace Solutions.Strings.Easy;

public static class ValidPalindrome
{
    public static bool Solution(string s) 
    {
        int i = 0;
        int j = s.Length - 1;
        
        while (i < j)
        {
            while (i < j && !char.IsLetterOrDigit(s[i])) ++i;
            while (i < j && !char.IsLetterOrDigit(s[j])) --j;
            
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
                return false;
            
            ++i;
            --j;
        }
        
        return true;
    }
}