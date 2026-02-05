// <copyright file="LongestCommonPrefixTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "LongestCommonPrefix".
/// </summary>
public class LongestCommonPrefixTestData : TestDataBase<LongestCommonPrefixTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string[], string>()
            .Add(
            [
                "preabc", "predef", "preghi"
            ],
            "pre")
            .Add(
            [
                "preabc", "predef", "prxghi"
            ],
            "pr")
            .Add(
            [
                "abc", "def", "ghi"
            ],
            string.Empty)
            .Add(
            [
                "prefix", "prefixabc", "prefixdef"
            ],
            "prefix");
    }
}
