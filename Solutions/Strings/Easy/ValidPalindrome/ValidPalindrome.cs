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
    /// <param name="str">The string to be checked for being a valid palindrome.</param>
    /// <returns>Whether the given string is a valid palindrome or not.</returns>
    public static bool Solution(string str)
    {
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            while (i < j && !char.IsLetterOrDigit(str[i]))
            {
                ++i;
            }

            while (i < j && !char.IsLetterOrDigit(str[j]))
            {
                --j;
            }

            if (char.ToLower(str[i]) != char.ToLower(str[j]))
            {
                return false;
            }

            ++i;
            --j;
        }

        return true;
    }
}
