// <copyright file="RemoveDuplicatesFromSortedArray.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

/// <summary>
/// Class implementing a solution to the "Remove Duplicates From Sorted Array" LeetCode problem.
/// </summary>
public static class RemoveDuplicatesFromSortedArray
{
    /// <summary>
    /// Implementation of the "Remove Duplicates From Sorted Array" LeetCode problem.
    /// </summary>
    /// <param name="nums">A sorted array of numbers containing duplicate values, on which the operation is performed.</param>
    /// <returns>The number of non-duplicate entries in the given array after the operation is performed.</returns>
    public static int Solution(int[] nums)
    {
        int numsCount = nums.Length;
        int k = 0; // Index of last unique number in nums array
        for (int i = 1; i < numsCount; ++i)
        {
            if (nums[k] != nums[i])
            {
                nums[++k] = nums[i];
            }
        }

        return k + 1;
    }
}
