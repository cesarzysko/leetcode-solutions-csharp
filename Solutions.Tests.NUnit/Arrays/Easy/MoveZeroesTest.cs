// <copyright file="MoveZeroesTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Arrays.Easy;

using MoveZeroes = Solutions.Arrays.Easy.MoveZeroes;
using MoveZeroesTestData = Solutions.Tests.Data.Arrays.Easy.MoveZeroesTestData;

/// <summary>
/// Class implementing tests logic for <see cref="MoveZeroes"/>.
/// </summary>
[TestFixture]
public sealed class MoveZeroesTest
{
    /// <summary>
    /// Tests whether the solution correctly moves zeroes to the back of the array without changing the order of the other values.
    /// </summary>
    /// <param name="nums">The array to move zeroes in.</param>
    /// <param name="expectedNums">The expected result.</param>
    [Test]
    [TestCaseSource(typeof(MoveZeroesTestData))]
    public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
    {
        MoveZeroes.Solution(nums);

        int expectedK = expectedNums.Length;
        int actualK = nums.Length;
        using (Assert.EnterMultipleScope())
        {
            Assert.That(actualK, Is.EqualTo(expectedK));
            Assert.That(nums, Is.EqualTo(expectedNums));
        }
    }
}
