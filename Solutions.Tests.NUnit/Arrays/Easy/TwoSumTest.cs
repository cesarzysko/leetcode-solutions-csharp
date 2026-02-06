// <copyright file="TwoSumTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Arrays.Easy;

using TwoSum = Solutions.Arrays.Easy.TwoSum;
using TwoSumTestData = Solutions.Tests.Data.Arrays.Easy.TwoSumTestData;

/// <summary>
/// Class implementing tests logic for <see cref="TwoSum"/>.
/// </summary>
[TestFixture]
public sealed class TwoSumTest
{
    /// <summary>
    /// Tests whether the solution finds the correct two numbers which sum up to the target value.
    /// </summary>
    /// <param name="nums">The array of numbers to search in.</param>
    /// <param name="target">The target value to which the searched numbers need to sum up to.</param>
    /// <param name="expectedResult">The expected indexes of the two numbers which sum up to the target value.</param>
    [Test]
    [TestCaseSource(typeof(TwoSumTestData))]
    public void Solution_TwoSum_Test(int[] nums, int target, int[] expectedResult)
    {
        int[] actualResult = TwoSum.Solution(nums, target);
        Assert.That(actualResult, Has.Length.EqualTo(2));
        Assert.That(actualResult, Is.EqualTo(expectedResult));

        int actualTarget = nums[actualResult[0]] + nums[actualResult[1]];
        Assert.That(actualTarget, Is.EqualTo(target));
    }
}
