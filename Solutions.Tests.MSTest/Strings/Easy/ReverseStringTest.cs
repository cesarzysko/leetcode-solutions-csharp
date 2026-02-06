// <copyright file="ReverseStringTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Strings.Easy;

using ReverseString = Solutions.Strings.Easy.ReverseString;
using ReverseStringTestData = Solutions.Tests.Data.Strings.Easy.ReverseStringTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ReverseString"/>.
/// </summary>
[TestClass]
public sealed class ReverseStringTest
{
    /// <summary>
    /// Tests whether the solution correctly reverses the given string represented by an array of characters.
    /// </summary>
    /// <param name="text">The string to reverse.</param>
    /// <param name="expectedText">The expected result.</param>
    [TestMethod]
    [FromTestData(typeof(ReverseStringTestData))]
    public void Solution_ReverseString_Test(char[] text, char[] expectedText)
    {
        ReverseString.Solution(text);
        CollectionAssert.AreEqual(expectedText, text);
    }
}
