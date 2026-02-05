// <copyright file="RotateArray.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

/// <summary>
/// Class implementing a solution to the "Rotate Array" LeetCode problem.
/// </summary>
public static class RotateArray
{
    /// <summary>
    /// Implementation of the "Rotate Array" LeetCode problem.
    /// </summary>
    /// <param name="nums">The number array on which the rotation is to be performed.</param>
    /// <param name="k">The amount of rotation applied to the given array.</param>
    public static void Solution(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    private static void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            int temp = nums[left];
            nums[left++] = nums[right];
            nums[right--] = temp;
        }
    }
}
