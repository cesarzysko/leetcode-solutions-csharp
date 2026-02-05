// <copyright file="TwoSumTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "TwoSum".
/// </summary>
public sealed class TwoSumTestData : TestDataBase<TwoSumTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(int[] Nums, int Sum), int[]>()
            .DefineCustomArgConverter(args => [args.Nums, args.Sum])
            .Add(
                ([9, 1, 2, 3, 4, 5], 10),
                [0, 1])
            .Add(
                ([1, 2, 4, 9, 13, 15, 21], 15),
                [1, 4])
            .Add(
                ([-25, -11, 5, 11, 100], 0),
                [1, 3])
            .Add(
                ([-25, -11, 5, 11, 100], 89),
                [1, 4]);
    }
}
