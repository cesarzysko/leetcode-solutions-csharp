// <copyright file="ImplementStrStrTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Strings.Easy;

using ImplementStrStr = Solutions.Strings.Easy.ImplementStrStr;
using ImplementStrStrTestData = Solutions.Tests.Data.Strings.Easy.ImplementStrStrTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ImplementStrStr"/>.
/// </summary>
public class ImplementStrStrTest
{
    /// <summary>
    /// Tests whether the solution finds the index of the first occurrence of the needle string in haystack string.
    /// </summary>
    /// <param name="haystack">The string to search for needle in.</param>
    /// <param name="needle">The string searched for in haystack.</param>
    /// <param name="expectedResult">The expected index of the first occurence of the needle in haystack.</param>
    [Theory]
    [ClassData(typeof(ImplementStrStrTestData))]
    public void Solution_ImplementStrStr_Test(string haystack, string needle, int expectedResult)
    {
        int actualResult = ImplementStrStr.Solution(haystack, needle);
        Assert.Equal(expectedResult, actualResult);
    }
}
