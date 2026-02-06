// <copyright file="ContainsDuplicateTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Arrays.Easy;

using ContainsDuplicate = Solutions.Arrays.Easy.ContainsDuplicate;
using ContainsDuplicateTestData = Solutions.Tests.Data.Arrays.Easy.ContainsDuplicateTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ContainsDuplicate"/>.
/// </summary>
public sealed class ContainsDuplicateTest
{
    /// <summary>
    /// Tests whether the solution correctly detects a duplicate in the given array.
    /// </summary>
    /// <param name="nums">The array to check for duplicates.</param>
    /// <param name="expectedResult">The expected result of duplicate detection.</param>
    [Theory]
    [ClassData(typeof(ContainsDuplicateTestData))]
    public void Solution_ContainsDuplicate_Test(int[] nums, bool expectedResult)
    {
        bool actualResult = ContainsDuplicate.Solution(nums);
        Assert.Equal(expectedResult, actualResult);
    }
}
