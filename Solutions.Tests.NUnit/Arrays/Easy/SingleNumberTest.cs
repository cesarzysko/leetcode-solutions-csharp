// <copyright file="SingleNumberTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Arrays.Easy;

using SingleNumber = Solutions.Arrays.Easy.SingleNumber;
using SingleNumberTestData = Solutions.Tests.Data.Arrays.Easy.SingleNumberTestData;

/// <summary>
/// Class implementing tests logic for <see cref="SingleNumber"/>.
/// </summary>
[TestFixture]
public sealed class SingleNumberTest
{
    /// <summary>
    /// Tests whether the solution finds the only number in the array which does not have a pair.
    /// </summary>
    /// <param name="nums">The array of numbers.</param>
    /// <param name="expectedNum">The expected number without a pair.</param>
    [Test]
    [TestCaseSource(typeof(SingleNumberTestData))]
    public void Solution_SingleNumber_Test(int[] nums, int expectedNum)
    {
        int actualNum = SingleNumber.Solution(nums);
        Assert.That(actualNum, Is.EqualTo(expectedNum));
    }
}
