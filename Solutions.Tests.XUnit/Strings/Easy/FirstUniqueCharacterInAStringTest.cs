// <copyright file="FirstUniqueCharacterInAStringTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Strings.Easy;

using FirstUniqueCharacterInAString = Solutions.Strings.Easy.FirstUniqueCharacterInAString;
using FirstUniqueCharacterInAStringTestData = Solutions.Tests.Data.Strings.Easy.FirstUniqueCharacterInAStringTestData;

/// <summary>
/// Class implementing tests logic for <see cref="FirstUniqueCharacterInAString"/>.
/// </summary>
public sealed class FirstUniqueCharacterInAStringTest
{
    /// <summary>
    /// Tests whether the solution correctly finds the first unique character in the given string.
    /// </summary>
    /// <param name="str">The string to search for the unique character in.</param>
    /// <param name="expectedChIndex">The expected unique character to be found.</param>
    [Theory]
    [ClassData(typeof(FirstUniqueCharacterInAStringTestData))]
    public void Solution_FirstUniqueChar_Test(string str, int expectedChIndex)
    {
        int actualChIndex = FirstUniqueCharacterInAString.Solution(str);
        Assert.Equal(expectedChIndex, actualChIndex);
    }
}
