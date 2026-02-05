// <copyright file="FirstUniqueCharacterInAString.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

using System;

/// <summary>
/// Class implementing a solution to the "First Unique Character in a String" LeetCode problem.
/// </summary>
public static class FirstUniqueCharacterInAString
{
    /// <summary>
    /// Implementation of the "First Unique Character in a String" LeetCode problem.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int Solution(string s)
    {
        int[] uniqueCharIndexes = new int['z' - 'a' + 1];
        Array.Fill(uniqueCharIndexes, -1);
        int n = s.Length;
        for (int i = 0; i < n; ++i)
        {
            char c = s[i];
            int cIndex = c - 'a';
            if (uniqueCharIndexes[cIndex] == -1) // Does not occur in string s
            {
                uniqueCharIndexes[cIndex] = i;
            }
            else // Occurs more than once
            {
                uniqueCharIndexes[cIndex] = -2;
            }
        }

        int lowest = -1;
        foreach (int i in uniqueCharIndexes)
        {
            if (lowest == -1)
            {
                if (i >= 0)
                {
                    lowest = i;
                }
            }
            else if (i >= 0 && i < lowest)
            {
                lowest = i;
            }
        }

        return lowest;
    }
}