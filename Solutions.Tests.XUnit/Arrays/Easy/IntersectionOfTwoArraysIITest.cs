// <copyright file="IntersectionOfTwoArraysIITest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Arrays.Easy;

using IntersectionOfTwoArraysII = Solutions.Arrays.Easy.IntersectionOfTwoArraysII;
using IntersectionOfTwoArraysIITestData = Solutions.Tests.Data.Arrays.Easy.IntersectionOfTwoArraysIITestData;

/// <summary>
/// Class implementing tests logic for <see cref="IntersectionOfTwoArraysII"/>.
/// </summary>
public sealed class IntersectionOfTwoArraysIITest
{
    /// <summary>
    /// Tests whether the solution returns a proper intersection of two arrays.
    /// </summary>
    /// <param name="nums1">The first array.</param>
    /// <param name="nums2">The second array.</param>
    /// <param name="expectedIntersection">The expected intersection of both arrays.</param>
    [Theory]
    [ClassData(typeof(IntersectionOfTwoArraysIITestData))]
    public void Solution_Intersection_Test(int[] nums1, int[] nums2, int[] expectedIntersection)
    {
        int[] result = IntersectionOfTwoArraysII.Solution(nums1, nums2);
        int actualK = result.Length;
        int expectedK = expectedIntersection.Length;
        Assert.Equal(expectedK, actualK);
        short[] counts = new short[1001];

        for (int i = 0; i < expectedK; ++i)
        {
            int value = expectedIntersection[i];
            ++counts[value];
        }

        for (int i = 0; i < actualK; ++i)
        {
            int value = result[i];
            Assert.InRange(value, 0, 1000);
            Assert.True(--counts[value] >= 0, $"Unexpected extra value \"{value}\".");
        }
    }
}
