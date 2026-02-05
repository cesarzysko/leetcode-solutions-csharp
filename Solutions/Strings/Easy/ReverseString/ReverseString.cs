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
    /// <param name="s"></param>
    public static void Solution(char[] s)
    {
        Array.Reverse(s);
    }
}