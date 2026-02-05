// <copyright file="ValidPalindromeTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "ValidPalindrome".
/// </summary>
public class ValidPalindromeTestData : TestDataBase<ValidPalindromeTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, bool>()
            .Add(
                "A man, a plan, a canal: Panama",
                true)
            .Add(
                "race a car",
                false)
            .Add(
                " ",
                true)
            .Add(
                "1 2 34 .321",
                true)
            .Add(
                "Madam, I'm Adam",
                true)
            .Add(
                "!M@ad--am, I'\\m Ad#am/",
                true)
            .Add(
                "appbappa",
                false);
    }
}
