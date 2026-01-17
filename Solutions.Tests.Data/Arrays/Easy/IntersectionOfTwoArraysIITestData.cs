using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public class IntersectionOfTwoArraysIITestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new IntersectionOfTwoArraysIITestData();

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [0],
            [1],
            []
        );
        yield return Case(
            [1, 2, 3, 4, 5],
            [5, 4, 3, 2, 1],
            [1, 2, 3, 4, 5]
        );
        yield return Case(
            [0, 10, 11, 11, 11, 20],
            [1, 2, 3, 11, 10, 22, 13, 11],
            [10, 11, 11]
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(int[] nums1, int[] nums2, int[] expectedIntersection)
        => [nums1, nums2, expectedIntersection];
}