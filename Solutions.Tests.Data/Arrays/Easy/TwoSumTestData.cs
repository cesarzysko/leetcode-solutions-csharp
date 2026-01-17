using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class TwoSumTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new TwoSumTestData();
        
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [9, 1, 2, 3, 4, 5],
            10,
            [0, 1]
        );
        yield return Case(
            [1, 2, 4, 9, 13, 15, 21],
            15,
            [1, 4]
        );
        yield return Case(
            [-25, -11, 5, 11, 100],
            0,
            [1, 3]
        );
        yield return Case(
            [-25, -11, 5, 11, 100],
            89,
            [1, 4]
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(int[] nums, int target, int[] expectedResult)
        => [nums, target, expectedResult];
}