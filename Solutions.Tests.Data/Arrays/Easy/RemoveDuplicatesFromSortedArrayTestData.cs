using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class RemoveDuplicatesFromSortedArrayTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new RemoveDuplicatesFromSortedArrayTestData();

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [1, 1, 1, 2, 2, 3],
            [1, 2, 3]
        );
        yield return Case(
            [2, 2, 4, 5, 8, 11, 11, 11, 11, 15, 100],
            [2, 4, 5, 8, 11, 15, 100]
        );
        yield return Case(
            [4, 7, 9, 11, 13, 101],
            [4, 7, 9, 11, 13, 101]
        );
        yield return Case(
            [0],
            [0]
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    private static object[] Case(int[] nums, int[] expectedNums) 
        => [nums, expectedNums];
}