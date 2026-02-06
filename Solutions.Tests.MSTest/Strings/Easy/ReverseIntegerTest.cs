// <copyright file="ReverseIntegerTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Strings.Easy;

using ReverseInteger = Solutions.Strings.Easy.ReverseInteger;
using ReverseIntegerTestData = Solutions.Tests.Data.Strings.Easy.ReverseIntegerTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ReverseInteger"/>.
/// </summary>
[TestClass]
public sealed class ReverseIntegerTest
{
    /// <summary>
    /// Tests whether the solution correctly reverses the given integer.
    /// </summary>
    /// <param name="x">The integer to reverse.</param>
    /// <param name="expectedResult">The expected result.</param>
    [TestMethod]
    [FromTestData(typeof(ReverseIntegerTestData))]
    public void Solution_ReverseInteger_Test(int x, int expectedResult)
    {
        int result = ReverseInteger.Solution(x);
        Assert.AreEqual(expectedResult, result);
    }
}
