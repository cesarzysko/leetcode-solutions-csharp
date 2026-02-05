// <copyright file="ReverseInteger.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

/// <summary>
/// Class implementing a solution to the "Reverse Integer" LeetCode problem.
/// </summary>
public static class ReverseInteger
{
    /// <summary>
    /// Implementation of the "Reverse Integer" LeetCode problem.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int Solution(int x)
    {
        long reverse = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;
            reverse = (reverse * 10) + pop;
            if (reverse is < int.MinValue or > int.MaxValue)
            {
                return 0;
            }
        }

        return (int)reverse;
    }
}