// <copyright file="ContainsDuplicateTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "ContainsDuplicate".
/// </summary>
public sealed class ContainsDuplicateTestData : TestDataBase<ContainsDuplicateTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], bool>()
            .Add(
                [1, 2, 3, 4, 5],
                false)
            .Add(
                [1, 4, 3, 10, 5],
                false)
            .Add(
                [1],
                false)
            .Add(
                [1, 1],
                true)
            .Add(
                [1, 0, 3, 1, 9],
                true);
    }
}
