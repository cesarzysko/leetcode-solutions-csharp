// <copyright file="IntersectionOfTwoArraysII.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

using System.Collections.Generic;

/// <summary>
/// Class implementing a solution to the "Intersection of Two Arrays II" LeetCode problem.
/// </summary>
public static class IntersectionOfTwoArraysII
{
    /// <summary>
    /// Implementation of the "Intersection of Two Arrays II" LeetCode problem.
    /// </summary>
    /// <param name="nums1">The first array of numbers.</param>
    /// <param name="nums2">The second array of numbers.</param>
    /// <returns>The intersection of both given arrays.</returns>
    public static int[] Solution(int[] nums1, int[] nums2)
    {
        int n = nums1.Length;
        List<int> intersection = [];
        Dictionary<int, IntWrapper> dict = [];

        for (int i = 0; i < n; ++i)
        {
            int key = nums1[i];
            if (dict.TryGetValue(key, out IntWrapper? occurrences))
            {
                ++occurrences.Value;
            }
            else
            {
                dict.Add(key, new IntWrapper(1));
            }
        }

        n = nums2.Length;

        for (int i = 0; i < n; ++i)
        {
            int key = nums2[i];
            if (!dict.TryGetValue(key, out IntWrapper? occurrences))
            {
                continue;
            }

            intersection.Add(key);
            if (--occurrences.Value == 0)
            {
                dict.Remove(key);
            }
        }

        return intersection.ToArray();
    }

    private sealed class IntWrapper(int val)
    {
        public int Value { get; set; } = val;
    }
}
