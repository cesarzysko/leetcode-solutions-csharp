// <copyright file="ValidAnagram.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

/// <summary>
/// Class implementing a solution to the "Valid Anagram" LeetCode problem.
/// </summary>
public static class ValidAnagram
{
    /// <summary>
    /// Implementation of the "Valid Anagram" LeetCode problem.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
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