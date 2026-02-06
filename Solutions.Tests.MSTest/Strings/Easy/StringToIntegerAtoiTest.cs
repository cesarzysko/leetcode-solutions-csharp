// <copyright file="StringToIntegerAtoiTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Strings.Easy;

using StringToIntegerAtoiTestData = Solutions.Tests.Data.Strings.Easy.StringToIntegerAtoiTestData;
using StringToIntegerAtoi = Solutions.Strings.Easy.StringToIntegerAtoi;

/// <summary>
/// Class implementing tests logic for <see cref="StringToIntegerAtoi"/>.
/// </summary>
[TestClass]
public class StringToIntegerAtoiTest
{
    /// <summary>
    /// Tests whether the solution correctly parses the given string into an integer value.
    /// </summary>
    /// <param name="str">The string to parse.</param>
    /// <param name="expectedResult">The expected parsed value.</param>
    [TestMethod]
    [FromTestData(typeof(StringToIntegerAtoiTestData))]
    public void Solution_StringToInteger_Test(string str, int expectedResult)
    {
        int result = StringToIntegerAtoi.Solution(str);
        Assert.AreEqual(expectedResult, result);
    }
}
