// <copyright file="PlusOneTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Arrays.Easy;

using PlusOne = Solutions.Arrays.Easy.PlusOne;
using PlusOneTestData = Solutions.Tests.Data.Arrays.Easy.PlusOneTestData;

/// <summary>
/// Class implementing tests logic for <see cref="PlusOne"/>.
/// </summary>
[TestFixture]
public sealed class PlusOneTest
{
    /// <summary>
    /// Tests whether the solution correctly increments by one the number represented as an array of digits.
    /// </summary>
    /// <param name="digits">The number to increment represented as an array of digits.</param>
    /// <param name="expectedDigits">The expected result.</param>
    [Test]
    [TestCaseSource(typeof(PlusOneTestData))]
    public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
    {
        int[] actualDigits = PlusOne.Solution(digits);

        int actualK = actualDigits.Length;
        int expectedK = expectedDigits.Length;
        using (Assert.EnterMultipleScope())
        {
            Assert.That(actualK, Is.EqualTo(expectedK));
            Assert.That(actualDigits, Is.EqualTo(expectedDigits));
        }
    }
}
