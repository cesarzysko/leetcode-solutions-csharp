// <copyright file="ValidPalindromeTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.NUnit.Strings.Easy;

using ValidPalindrome = Solutions.Strings.Easy.ValidPalindrome;
using ValidPalindromeTestData = Solutions.Tests.Data.Strings.Easy.ValidPalindromeTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ValidPalindrome"/>.
/// </summary>
[TestFixture]
public class ValidPalindromeTest
{
    /// <summary>
    /// Tests whether the solution correctly detects if the given string is a palindrome.
    /// </summary>
    /// <param name="str">The string to check for being a palindrome.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Test]
    [TestCaseSource(typeof(ValidPalindromeTestData))]
    public void Solution_ValidPalindrome_Test(string str, bool expectedResult)
    {
        bool result = ValidPalindrome.Solution(str);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
