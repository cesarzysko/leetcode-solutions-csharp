// <copyright file="RemoveDuplicatesFromSortedArrayTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Arrays.Easy;

using RemoveDuplicatesFromSortedArray = Solutions.Arrays.Easy.RemoveDuplicatesFromSortedArray;
using RemoveDuplicatesFromSortedArrayTestData = Solutions.Tests.Data.Arrays.Easy.RemoveDuplicatesFromSortedArrayTestData;

/// <summary>
/// Class implementing tests logic for <see cref="RemoveDuplicatesFromSortedArray"/>.
/// </summary>
[TestFixture]
public sealed class RemoveDuplicatesFromSortedArrayTest
{
    /// <summary>
    /// Tests whether the solution correctly removes duplicates from an array and returns the correct new size.
    /// </summary>
    /// <param name="nums">The array containing duplicates.</param>
    /// <param name="expectedNums">The expected result without duplicates.</param>
    [Test]
    [TestCaseSource(typeof(RemoveDuplicatesFromSortedArrayTestData))]
    public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
    {
        int expectedK = expectedNums.Length;
        int actualK = RemoveDuplicatesFromSortedArray.Solution(nums);
        using (Assert.EnterMultipleScope())
        {
            Assert.That(actualK, Is.EqualTo(expectedK));
            Assert.That(nums[..actualK], Is.EqualTo(expectedNums));
        }
    }
}
