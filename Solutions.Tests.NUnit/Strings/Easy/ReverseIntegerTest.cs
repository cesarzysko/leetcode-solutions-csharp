// <copyright file="ReverseIntegerTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Strings.Easy;

using ReverseInteger = Solutions.Strings.Easy.ReverseInteger;
using ReverseIntegerTestData = Solutions.Tests.Data.Strings.Easy.ReverseIntegerTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ReverseInteger"/>.
/// </summary>
[TestFixture]
public sealed class ReverseIntegerTest
{
    /// <summary>
    /// Tests whether the solution correctly reverses the given integer.
    /// </summary>
    /// <param name="x">The integer to reverse.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Test]
    [TestCaseSource(typeof(ReverseIntegerTestData))]
    public void Solution_ReverseInteger_Test(int x, int expectedResult)
    {
        int actualResult = ReverseInteger.Solution(x);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
