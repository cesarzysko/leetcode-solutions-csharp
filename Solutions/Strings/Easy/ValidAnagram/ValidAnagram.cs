namespace Solutions.Strings.Easy;

public static class ValidAnagram
{
    public static bool Solution(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        int n = s.Length;
        int c = 'z' - 'a' + 1;
        int[] count = new int[c];
        
        for (int i = 0; i < n; i++) 
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        for (int i = 0; i < c; ++i) 
        {
            if (count[i] != 0)
            {
                return false;
            }
        }
        
        return true;
    }
}