// <copyright file="ReverseString.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

using System;

/// <summary>
/// Class implementing a solution to the "Reverse String" LeetCode problem.
/// </summary>
public static class ReverseString
{
    /// <summary>
    /// Implementation of the "Reverse String" LeetCode problem.
    /// </summary>
    /// <param name="str">An array of characters representing a string to be reversed.</param>
    public static void Solution(char[] str)
    {
        int n = str.Length;
        for (int i = 0; i < n / 2; ++i)
        {
            char temp = str[i];
            str[i] = str[n - i - 1];
            str[n - i - 1] = temp;
        }
    }
}
