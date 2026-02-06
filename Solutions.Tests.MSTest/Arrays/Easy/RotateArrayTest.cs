// <copyright file="RotateArrayTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Arrays.Easy;

using RotateArray = Solutions.Arrays.Easy.RotateArray;
using RotateArrayTestData = Solutions.Tests.Data.Arrays.Easy.RotateArrayTestData;

/// <summary>
/// Class implementing tests logic for <see cref="RotateArray"/>.
/// </summary>
[TestClass]
public sealed class RotateArrayTest
{
    /// <summary>
    /// Tests whether the solution correctly rotates an array by the given number of times.
    /// </summary>
    /// <param name="nums">The array to rotate.</param>
    /// <param name="k">The number of times to rotate the array.</param>
    /// <param name="expectedNums">The expected result after all rotations are applied.</param>
    [TestMethod]
    [FromTestData(typeof(RotateArrayTestData))]
    public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
    {
        RotateArray.Solution(nums, k);
        CollectionAssert.AreEqual(expectedNums, nums);
    }
}
