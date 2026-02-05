// <copyright file="ValidPalindrome.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

/// <summary>
/// Class implementing a solution to the "Valid Palindrome" LeetCode problem.
/// </summary>
public static class ValidPalindrome
{
    /// <summary>
    /// Implementation of the "Valid Palindrome" LeetCode problem.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool Solution(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            while (i < j && !char.IsLetterOrDigit(s[i]))
            {
                ++i;
            }

            while (i < j && !char.IsLetterOrDigit(s[j]))
            {
                --j;
            }

            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }

            ++i;
            --j;
        }

        return true;
    }
}