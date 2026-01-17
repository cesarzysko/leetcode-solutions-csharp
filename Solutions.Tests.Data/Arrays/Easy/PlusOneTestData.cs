using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class PlusOneTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new PlusOneTestData();

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [0],
            [1]
        );
        yield return Case(
            [4, 2],
            [4, 3]
        );
        yield return Case(
            [9],
            [1, 0]
        );
        yield return Case(
            [1, 2, 3, 9, 7, 9],
            [1, 2, 3, 9, 8, 0]
        );
        yield return Case(
            [9, 9, 9, 9, 9, 9, 9, 9, 9],
            [1, 0, 0, 0, 0, 0, 0, 0, 0, 0]
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    private static object[] Case(int[] digits, int[] expectedDigits) 
        => [digits, expectedDigits];
}