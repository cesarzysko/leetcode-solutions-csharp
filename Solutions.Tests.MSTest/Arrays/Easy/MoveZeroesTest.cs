// <copyright file="MoveZeroesTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Arrays.Easy;

using MoveZeroes = Solutions.Arrays.Easy.MoveZeroes;
using MoveZeroesTestData = Solutions.Tests.Data.Arrays.Easy.MoveZeroesTestData;

/// <summary>
/// Class implementing tests logic for <see cref="MoveZeroes"/>.
/// </summary>
[TestClass]
public sealed class MoveZeroesTest
{
    /// <summary>
    /// Tests whether the solution correctly moves zeroes to the back of the array without changing the order of the other values.
    /// </summary>
    /// <param name="nums">The array to move zeroes in.</param>
    /// <param name="expectedNums">The expected result.</param>
    [TestMethod]
    [FromTestData(typeof(MoveZeroesTestData))]
    public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
    {
        MoveZeroes.Solution(nums);

        int eK = expectedNums.Length;
        int rK = nums.Length;
        Assert.AreEqual(eK, rK);
        CollectionAssert.AreEqual(expectedNums, nums);
    }
}
