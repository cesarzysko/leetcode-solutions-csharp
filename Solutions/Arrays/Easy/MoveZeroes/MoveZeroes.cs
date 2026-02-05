// <copyright file="MoveZeroes.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

/// <summary>
/// Class implementing a solution to the "Move Zeroes" LeetCode problem.
/// </summary>
public static class MoveZeroes
{
    /// <summary>
    /// Implementation of the "Move Zeroes" LeetCode problem.
    /// </summary>
    /// <param name="nums">The array of numbers on which the operation is performed.</param>
    public static void Solution(int[] nums)
    {
        int n = nums.Length;
        int w = 0;
        for (int i = 0; i < n; ++i)
        {
            int num = nums[i];
            if (num != 0)
            {
                nums[w++] = num;
            }
        }

        while (w < n)
        {
            nums[w++] = 0;
        }
    }
}
