// <copyright file="ValidAnagramTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "ValidAnagram".
/// </summary>
public class ValidAnagramTestData : TestDataBase<ValidAnagramTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(string Str, string AnagramStr), bool>()
            .DefineCustomArgConverter(args => [args.Str, args.AnagramStr])
            .Add(
                ("turtle", "leturt"),
                true)
            .Add(
                ("anagram", "nagamam"),
                false)
            .Add(
                ("abba", "baab"),
                true)
            .Add(
                ("anagrram", "anagrramm"),
                false)
            .Add(
                ("anagramm", "anagrammm"),
                false);
    }
}
