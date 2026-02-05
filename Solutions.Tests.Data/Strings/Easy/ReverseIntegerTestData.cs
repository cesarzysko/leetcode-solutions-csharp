// <copyright file="ReverseIntegerTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Strings.Easy;

/// <summary>
/// Encapsulates test cases for testing "ReverseInteger".
/// </summary>
public sealed class ReverseIntegerTestData : TestDataBase<ReverseIntegerTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int, int>()
            .Add(
                12,
                21)
            .Add(
                int.MaxValue,
                0)
            .Add(
                int.MinValue,
                0)
            .Add(
                123_456_789,
                987_654_321)
            .Add(
                -123_456_789,
                -987_654_321)
            .Add(
                1_000_000_008,
                0);
    }
}
