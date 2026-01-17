using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public class MoveZeroesTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new MoveZeroesTestData();

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [0],
            [0]
        );
        yield return Case(
            [1],
            [1]
        );
        yield return Case(
            [0, 1],
            [1, 0]
        );
        yield return Case(
            [0, 0, 0, 1, 0],
            [1, 0, 0, 0, 0]
        );
        yield return Case(
            [0, 1, 0, 2, 0, 3, 0],
            [1, 2, 3, 0, 0, 0, 0]
        );
        yield return Case(
            [1, 2, 0, 3, 0, 4, 5],
            [1, 2, 3, 4, 5, 0, 0]
        );
        yield return Case(
            [1, 2, 3, 4, 5, 0, 0],
            [1, 2, 3, 4, 5, 0, 0]
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    private static object[] Case(int[] nums, int[] expectedNums) 
        => [nums, expectedNums];
}