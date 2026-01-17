using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class SingleNumberTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new SingleNumberTestData();
        
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [0],
            0
        );
        yield return Case(
            [1, 0, 0],
            1
        );
        yield return Case(
            [0, 1, 0],
            1
        );
        yield return Case(
            [0, 0, 1],
            1
        );
        yield return Case(
            [0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0],
            5
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(int[] nums, int expectedNum)
        => [nums, expectedNum];
}