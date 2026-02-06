// <copyright file="RemoveDuplicatesFromSortedArrayTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Arrays.Easy;

using RemoveDuplicatesFromSortedArray = Solutions.Arrays.Easy.RemoveDuplicatesFromSortedArray;
using RemoveDuplicatesFromSortedArrayTestData = Solutions.Tests.Data.Arrays.Easy.RemoveDuplicatesFromSortedArrayTestData;

/// <summary>
/// Class implementing tests logic for <see cref="RemoveDuplicatesFromSortedArray"/>.
/// </summary>
[TestClass]
public sealed class RemoveDuplicatesFromSortedArrayTest
{
    /// <summary>
    /// Tests whether the solution correctly removes duplicates from an array and returns the correct new size.
    /// </summary>
    /// <param name="nums">The array containing duplicates.</param>
    /// <param name="expectedNums">The expected result without duplicates.</param>
    [TestMethod]
    [FromTestData(typeof(RemoveDuplicatesFromSortedArrayTestData))]
    public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
    {
        int expectedK = expectedNums.Length;
        int k = RemoveDuplicatesFromSortedArray.Solution(nums);
        Assert.AreEqual(expectedK, k);
        CollectionAssert.AreEqual(expectedNums, nums[..k]);
    }
}
