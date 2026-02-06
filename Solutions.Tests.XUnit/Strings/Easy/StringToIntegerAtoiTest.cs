// <copyright file="StringToIntegerAtoiTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Strings.Easy;

using StringToIntegerAtoi = Solutions.Strings.Easy.StringToIntegerAtoi;
using StringToIntegerAtoiTestData = Solutions.Tests.Data.Strings.Easy.StringToIntegerAtoiTestData;

/// <summary>
/// Class implementing tests logic for <see cref="StringToIntegerAtoi"/>.
/// </summary>
public class StringToIntegerAtoiTest
{
    /// <summary>
    /// Tests whether the solution correctly parses the given string into an integer value.
    /// </summary>
    /// <param name="str">The string to parse.</param>
    /// <param name="expectedResult">The expected parsed value.</param>
    [Theory]
    [ClassData(typeof(StringToIntegerAtoiTestData))]
    public void Solution_StringToInteger_Test(string str, int expectedResult)
    {
        int actualResult = StringToIntegerAtoi.Solution(str);
        Assert.Equal(expectedResult, actualResult);
    }
}
