// <copyright file="MoveZeroesTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "MoveZeroes".
/// </summary>
public sealed class MoveZeroesTestData : TestDataBase<MoveZeroesTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int[]>()
            .Add(
                [0],
                [0])
            .Add(
                [1],
                [1])
            .Add(
                [0, 1],
                [1, 0])
            .Add(
                [0, 0, 0, 1, 0],
                [1, 0, 0, 0, 0])
            .Add(
                [0, 1, 0, 2, 0, 3, 0],
                [1, 2, 3, 0, 0, 0, 0])
            .Add(
                [1, 2, 0, 3, 0, 4, 5],
                [1, 2, 3, 4, 5, 0, 0])
            .Add(
                [1, 2, 3, 4, 5, 0, 0],
                [1, 2, 3, 4, 5, 0, 0]);
    }
}
