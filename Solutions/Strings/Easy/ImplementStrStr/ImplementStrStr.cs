namespace Solutions.Strings.Easy;

public static class ImplementStrStr
{
    public static int Solution(string haystack, string needle) 
    {
        int hN = haystack.Length;
        int nN = needle.Length;
        for (int i = 0; i <= hN - nN; ++i)
        {
            bool found = true;
            for (int j = 0; j < nN; ++j)
            {
                if (haystack[i + j] != needle[j])
                {
                    found = false;
                    break;
                }
            }

            if (found) return i;
        }

        return -1;
    }
}