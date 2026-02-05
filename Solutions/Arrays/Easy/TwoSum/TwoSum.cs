// <copyright file="TwoSum.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

using System.Collections.Generic;

/// <summary>
/// Class implementing a solution to the "Two Sum" LeetCode problem.
/// </summary>
public static class TwoSum
{
    /// <summary>
    /// Implementation of the "Two Sum" LeetCode problem.
    /// </summary>
    /// <param name="nums">The array of numbers on which the sum search towards target value is performed.</param>
    /// <param name="target">The target value for the two sum search.</param>
    /// <returns>
    /// An array containing a pair of indexes for which the numbers in the given array sum up to the target value
    /// or [-1, -1] if no such pair is found.
    /// </returns>
    public static int[] Solution(int[] nums, int target)
    {
        int n = nums.Length;
        Dictionary<int, int> discovered = [];
        for (int i = 0; i < n; ++i)
        {
            int val = nums[i];
            int needed = target - val;
            if (discovered.TryGetValue(needed, out int j))
            {
                return [j, i];
            }

            discovered[val] = i;
        }

        return [-1, -1];
    }
}
