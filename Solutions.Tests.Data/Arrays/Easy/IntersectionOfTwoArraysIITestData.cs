// <copyright file="IntersectionOfTwoArraysIITestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "IntersectionOfTwoArraysII".
/// </summary>
public sealed class IntersectionOfTwoArraysIITestData : TestDataBase<IntersectionOfTwoArraysIITestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(int[] FirstArray, int[] SecondArray), int[]>()
            .DefineCustomArgConverter(args => [args.FirstArray, args.SecondArray])
            .Add(
                ([0], [1]),
                [])
            .Add(
                ([1, 2, 3, 4, 5], [5, 4, 3, 2, 1]),
                [1, 2, 3, 4, 5])
            .Add(
                ([0, 10, 11, 11, 11, 20], [1, 2, 3, 11, 10, 22, 13, 11]),
                [10, 11, 11]);
    }
}
