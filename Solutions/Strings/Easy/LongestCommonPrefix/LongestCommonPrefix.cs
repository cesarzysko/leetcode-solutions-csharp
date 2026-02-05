// <copyright file="LongestCommonPrefix.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

using System;

/// <summary>
/// Class implementing a solution to the "Longest Common Prefix" LeetCode problem.
/// </summary>
public static class LongestCommonPrefix
{
    /// <summary>
    /// Implementation of the "Longest Common Prefix" LeetCode problem.
    /// </summary>
    /// <param name="strings">An array of strings on which the longest common prefix is looked for.</param>
    /// <returns>The longest common prefix for the provided array.</returns>
    public static string Solution(string[] strings)
    {
        Array.Sort(strings);

        int n = strings.Length;
        int maxPrefixL = strings[0].Length;
        int p = -1;

        while (++p < maxPrefixL)
        {
            if (strings[0][p] != strings[n - 1][p])
            {
                break;
            }
        }

        return strings[0][..p];
    }
}
