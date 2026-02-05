// <copyright file="RemoveDuplicatesFromSortedArrayTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "RemoveDuplicatesFromSortedArray".
/// </summary>
public sealed class RemoveDuplicatesFromSortedArrayTestData : TestDataBase<RemoveDuplicatesFromSortedArrayTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int[]>()
            .Add(
                [1, 1, 1, 2, 2, 3],
                [1, 2, 3])
            .Add(
                [2, 2, 4, 5, 8, 11, 11, 11, 11, 15, 100],
                [2, 4, 5, 8, 11, 15, 100])
            .Add(
                [4, 7, 9, 11, 13, 101],
                [4, 7, 9, 11, 13, 101])
            .Add(
                [0],
                [0]);
    }
}
