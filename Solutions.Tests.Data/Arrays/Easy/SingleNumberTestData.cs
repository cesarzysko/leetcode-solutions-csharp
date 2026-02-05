// <copyright file="SingleNumberTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "SingleNumber".
/// </summary>
public sealed class SingleNumberTestData : TestDataBase<SingleNumberTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int>()
            .Add(
                [0],
                0)
            .Add(
                [1, 0, 0],
                1)
            .Add(
                [0, 1, 0],
                1)
            .Add(
                [0, 0, 1],
                1)
            .Add(
                [0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0],
                5);
    }
}
