// <copyright file="SingleNumber.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

/// <summary>
/// Class implementing a solution to the "Single Number" LeetCode problem.
/// </summary>
public static class SingleNumber
{
    /// <summary>
    /// Implementation of the "Single Number" LeetCode problem.
    /// </summary>
    /// <param name="nums">The array of numbers on which the search for the only single number occurs.</param>
    /// <returns>The only single number found within the given array.</returns>
    public static int Solution(int[] nums)
    {
        int n = nums.Length;
        int result = 0;
        for (int i = 0; i < n; ++i)
        {
            result ^= nums[i];
        }

        return result;
    }
}