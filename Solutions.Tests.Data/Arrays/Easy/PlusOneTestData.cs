// <copyright file="PlusOneTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "PlusOne".
/// </summary>
public sealed class PlusOneTestData : TestDataBase<PlusOneTestData>
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
                [1])
            .Add(
                [4, 2],
                [4, 3])
            .Add(
                [9],
                [1, 0])
            .Add(
                [1, 2, 3, 9, 7, 9],
                [1, 2, 3, 9, 8, 0])
            .Add(
                [9, 9, 9, 9, 9, 9, 9, 9, 9],
                [1, 0, 0, 0, 0, 0, 0, 0, 0, 0]);
    }
}
