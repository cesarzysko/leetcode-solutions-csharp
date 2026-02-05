// <copyright file="ReverseStringTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "ReverseString".
/// </summary>
public sealed class ReverseStringTestData : TestDataBase<ReverseStringTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, string>()
            .DefineCustomArgConverter(s => [s.ToCharArray()])
            .DefineCustomOutConverter(s => [s.ToCharArray()])
            .Add(
                "abba",
                "abba")
            .Add(
                "dada",
                "adad")
            .Add(
                "abcdefghijk",
                "kjihgfedcba")
            .Add(
                "12#90*.\\$@",
                "@$\\.*09#21");
    }
}
