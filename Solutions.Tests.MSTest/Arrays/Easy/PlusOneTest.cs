// <copyright file="PlusOneTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Arrays.Easy;

using PlusOne = Solutions.Arrays.Easy.PlusOne;
using PlusOneTestData = Solutions.Tests.Data.Arrays.Easy.PlusOneTestData;

/// <summary>
/// Class implementing tests logic for <see cref="PlusOne"/>.
/// </summary>
[TestClass]
public sealed class PlusOneTest
{
    /// <summary>
    /// Tests whether the solution correctly increments by one the number represented as an array of digits.
    /// </summary>
    /// <param name="digits">The number to increment represented as an array of digits.</param>
    /// <param name="expectedDigits">The expected result.</param>
    [TestMethod]
    [FromTestData(typeof(PlusOneTestData))]
    public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
    {
        int[] result = PlusOne.Solution(digits);

        int rK = result.Length;
        int eK = expectedDigits.Length;
        Assert.AreEqual(eK, rK);
        CollectionAssert.AreEqual(expectedDigits, result);
    }
}
