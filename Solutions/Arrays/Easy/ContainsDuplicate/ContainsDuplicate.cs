// <copyright file="ContainsDuplicate.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

using System.Collections.Generic;

/// <summary>
/// Class implementing a solution to the "Contains Duplicate" LeetCode problem.
/// </summary>
public static class ContainsDuplicate
{
    /// <summary>
    /// Implementation of the "Contains Duplicate" LeetCode problem.
    /// </summary>
    /// <param name="nums">The array of numbers to check for duplicates.</param>
    /// <returns>Whether the provided array contains any duplicate or not.</returns>
    public static bool Solution(int[] nums)
    {
        int n = nums.Length;
        HashSet<int> keys = new HashSet<int>(n);
        for (int i = 0; i < n; ++i)
        {
            if (!keys.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
