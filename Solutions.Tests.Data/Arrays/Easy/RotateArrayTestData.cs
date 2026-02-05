// <copyright file="RotateArrayTestData.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data.Arrays.Easy;

/// <summary>
/// Encapsulates test cases for testing "RotateArray".
/// </summary>
public sealed class RotateArrayTestData : TestDataBase<RotateArrayTestData>
{
    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(int[] Arr, int Rot), int[]>()
            .DefineCustomArgConverter(args => [args.Arr, args.Rot])
            .Add(
                ([1, 2, 3, 4, 5], 0),
                [1, 2, 3, 4, 5])
            .Add(
                ([1, 2, 3, 4, 5], 1),
                [5, 1, 2, 3, 4])
            .Add(
                ([1, 2, 3, 4, 5], 5),
                [1, 2, 3, 4, 5])
            .Add(
                ([1, 2, 3, 4, 5], 10),
                [1, 2, 3, 4, 5]);
    }
}
