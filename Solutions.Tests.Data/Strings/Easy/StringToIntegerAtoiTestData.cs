// <copyright file="StringToIntegerAtoiTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "StringToIntegerAtoi".
/// </summary>
public class StringToIntegerAtoiTestData : TestDataBase<StringToIntegerAtoiTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, int>()
            .Add(
                "42",
                42)
            .Add(
                "-042",
                -42)
            .Add(
                "1337c0d3",
                1337)
            .Add(
                "0-1",
                0)
            .Add(
                "words and 987",
                0);
    }
}
