// <copyright file="ValidAnagramTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Strings.Easy;

using ValidAnagram = Solutions.Strings.Easy.ValidAnagram;
using ValidAnagramTestData = Solutions.Tests.Data.Strings.Easy.ValidAnagramTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ValidAnagram"/>.
/// </summary>
[TestClass]
public class ValidAnagramTest
{
    /// <summary>
    /// Tests whether the solution correctly detects if the second string is an anagram of the first one.
    /// </summary>
    /// <param name="str1">The first string.</param>
    /// <param name="str2">The second string.</param>
    /// <param name="expectedResult">The expected result.</param>
    [TestMethod]
    [FromTestData(typeof(ValidAnagramTestData))]
    public void Solution_ValidAnagram_Test(string str1, string str2, bool expectedResult)
    {
        bool firstResult = ValidAnagram.Solution(str1, str2);
        bool secondResult = ValidAnagram.Solution(str2, str1);

        Assert.AreEqual(expectedResult, firstResult);
        Assert.AreEqual(expectedResult, secondResult);
    }
}
