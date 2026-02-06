// <copyright file="IntersectionOfTwoArraysIITest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Arrays.Easy;

using IntersectionOfTwoArraysII = Solutions.Arrays.Easy.IntersectionOfTwoArraysII;
using IntersectionOfTwoArraysIITestData = Solutions.Tests.Data.Arrays.Easy.IntersectionOfTwoArraysIITestData;

/// <summary>
/// Class implementing tests logic for <see cref="IntersectionOfTwoArraysII"/>.
/// </summary>
[TestFixture]
public sealed class IntersectionOfTwoArraysIITest
{
    /// <summary>
    /// Tests whether the solution returns a proper intersection of two arrays.
    /// </summary>
    /// <param name="nums1">The first array.</param>
    /// <param name="nums2">The second array.</param>
    /// <param name="expectedIntersection">The expected intersection of both arrays.</param>
    [Test]
    [TestCaseSource(typeof(IntersectionOfTwoArraysIITestData))]
    public void Solution_Intersection_Test(int[] nums1, int[] nums2, int[] expectedIntersection)
    {
        int[] result = IntersectionOfTwoArraysII.Solution(nums1, nums2);

        int rK = result.Length;
        int eK = expectedIntersection.Length;
        Assert.That(rK, Is.EqualTo(eK));

        short[] counts = new short[1001];

        for (int i = 0; i < eK; ++i)
        {
            int value = expectedIntersection[i];
            ++counts[value];
        }

        for (int i = 0; i < rK; ++i)
        {
            int value = result[i];
            using (Assert.EnterMultipleScope())
            {
                Assert.That(value, Is.InRange(0, 1000));
                Assert.That(--counts[value], Is.GreaterThanOrEqualTo(0), $"Unexpected extra value \"{value}\".");
            }
        }
    }
}
