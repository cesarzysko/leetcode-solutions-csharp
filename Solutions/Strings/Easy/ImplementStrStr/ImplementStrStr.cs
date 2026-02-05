// <copyright file="ImplementStrStr.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

/// <summary>
/// Class implementing a solution to the "Implement strStr()" LeetCode problem.
/// </summary>
public static class ImplementStrStr
{
    /// <summary>
    /// Implementation of the "Implement strStr()" LeetCode problem.
    /// </summary>
    /// <param name="haystack">The source string in which the needle is searched for.</param>
    /// <param name="needle">The string looked for in the haystack.</param>
    /// <returns>The index of the first occurance of needle in haystack, or -1 if none.</returns>
    public static int Solution(string haystack, string needle)
    {
        int hN = haystack.Length;
        int nN = needle.Length;
        for (int i = 0; i <= hN - nN; ++i)
        {
            bool found = true;
            for (int j = 0; j < nN; ++j)
            {
                if (haystack[i + j] == needle[j])
                {
                    continue;
                }

                found = false;
                break;
            }

            if (found)
            {
                return i;
            }
        }

        return -1;
    }
}
