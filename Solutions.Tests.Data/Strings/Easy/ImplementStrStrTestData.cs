// <copyright file="ImplementStrStrTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "ImplementStrStr".
/// </summary>
public class ImplementStrStrTestData : TestDataBase<ImplementStrStrTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(string Str, string SearchedStr), int>()
            .DefineCustomArgConverter(args => [args.Str, args.SearchedStr])
            .Add(
                ("sadbutsad", "sad"),
                0)
            .Add(
                ("hello world, goodbye world", "world"),
                6)
            .Add(
                ("cat had a hat", "hada"),
                -1)
            .Add(
                ("hello", "goodbye"),
                -1);
    }
}
