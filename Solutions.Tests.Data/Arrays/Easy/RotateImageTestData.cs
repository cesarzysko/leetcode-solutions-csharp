using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public class RotateImageTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new RotateImageTestData();

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [
                [1]
            ],
            [
                [1]
            ]
        );
        yield return Case(
            [
                [1, 2],
                [3, 4]
            ],
            [
                [3, 1],
                [4, 2]
            ]
        );
        yield return Case(
            [
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            ],
            [
                [7, 4, 1],
                [8, 5, 2],
                [9, 6, 3]
            ]
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(int[][] matrix, int[][] expectedMatrix)
        => [matrix, expectedMatrix];
}