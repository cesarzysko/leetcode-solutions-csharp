using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Strings.Easy;

public sealed class ReverseIntegerTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new ReverseIntegerTestData();
        
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            12,
            21
        );
        yield return Case(
            int.MaxValue,
            0
        );
        yield return Case(
            int.MinValue,
            0
        );
        yield return Case(
            123_456_789,
            987_654_321
        );
        yield return Case(
            -123_456_789,
            -987_654_321
        );
        yield return Case(
            1_000_000_008,
            0
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(int x, int expectedResult)
        => [x, expectedResult];
}