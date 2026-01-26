using System;

namespace Solutions.Strings.Easy;

public static class LongestCommonPrefix
{
    public static string Solution(string[] strs) 
    {
        Array.Sort(strs);
        
        int n = strs.Length;
        int maxPrefixL = strs[0].Length;
        int p = -1;
        
        while (++p < maxPrefixL)
        {
            if (strs[0][p] != strs[n - 1][p]) { break; }
        }
        
        return strs[0][..p];
    }
}