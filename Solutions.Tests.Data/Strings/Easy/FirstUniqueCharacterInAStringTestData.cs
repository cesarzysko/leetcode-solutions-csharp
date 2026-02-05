// <copyright file="FirstUniqueCharacterInAStringTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "FirstUniqueCharacterInAString".
/// </summary>
public sealed class FirstUniqueCharacterInAStringTestData : TestDataBase<FirstUniqueCharacterInAStringTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, char>()
            .DefineCustomOutGenerator((s, c) => [s.IndexOf(c)])
            .Add(
                "a",
                'a')
            .Add(
                "aba",
                'b')
            .Add(
                "abcdefghijklmnopqrstuwvyzabcdefghijklmnopqrstuwyz",
                'v');
    }
}
