// <copyright file="LongestCommonPrefixTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Strings.Easy;

using LongestCommonPrefix = Solutions.Strings.Easy.LongestCommonPrefix;
using LongestCommonPrefixTestData = Solutions.Tests.Data.Strings.Easy.LongestCommonPrefixTestData;

/// <summary>
/// Class implementing tests logic for <see cref="LongestCommonPrefix"/>.
/// </summary>
public class LongestCommonPrefixTest
{
    /// <summary>
    /// Tests whether the solution returns the correct longest common prefix across the provided strings.
    /// </summary>
    /// <param name="strings">The strings to look for the longest common prefix in.</param>
    /// <param name="expectedResult">The expected longest common prefix.</param>
    [Theory]
    [ClassData(typeof(LongestCommonPrefixTestData))]
    public void Solution_LongestCommonPrefix_Test(string[] strings, string expectedResult)
    {
        string actualResult = LongestCommonPrefix.Solution(strings);
        Assert.Equal(expectedResult, actualResult);
    }
}
