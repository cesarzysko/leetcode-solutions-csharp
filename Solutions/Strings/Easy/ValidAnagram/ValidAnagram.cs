// <copyright file="ValidAnagram.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

/// <summary>
/// Class implementing a solution to the "Valid Anagram" LeetCode problem.
/// </summary>
public static class ValidAnagram
{
    private const int CountSize = 'z' - 'a' + 1;

    /// <summary>
    /// Implementation of the "Valid Anagram" LeetCode problem.
    /// </summary>
    /// <param name="str1">The first string to compare for a valid anagram.</param>
    /// <param name="str2">The second string to compare for a valid anagram.</param>
    /// <returns>Whether the second string is a valid anagram of the first one or not.</returns>
    public static bool Solution(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        int n = str1.Length;
        int[] count = new int[CountSize];

        for (int i = 0; i < n; i++)
        {
            count[str1[i] - 'a']++;
            count[str2[i] - 'a']--;
        }

        for (int i = 0; i < CountSize; ++i)
        {
            if (count[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}