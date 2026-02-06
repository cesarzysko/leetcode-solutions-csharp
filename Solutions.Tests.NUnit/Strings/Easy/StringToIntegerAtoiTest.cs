// <copyright file="StringToIntegerAtoiTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Strings.Easy;

using StringToIntegerAtoi = Solutions.Strings.Easy.StringToIntegerAtoi;
using StringToIntegerAtoiTestData = Solutions.Tests.Data.Strings.Easy.StringToIntegerAtoiTestData;

/// <summary>
/// Class implementing tests logic for <see cref="StringToIntegerAtoi"/>.
/// </summary>
[TestFixture]
public class StringToIntegerAtoiTest
{
    /// <summary>
    /// Tests whether the solution correctly parses the given string into an integer value.
    /// </summary>
    /// <param name="str">The string to parse.</param>
    /// <param name="expectedResult">The expected parsed value.</param>
    [Test]
    [TestCaseSource(typeof(StringToIntegerAtoiTestData))]
    public void Solution_StringToInteger_Test(string str, int expectedResult)
    {
        int result = StringToIntegerAtoi.Solution(str);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
