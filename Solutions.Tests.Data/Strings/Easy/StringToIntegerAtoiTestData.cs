using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Strings.Easy;

public class StringToIntegerAtoiTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new StringToIntegerAtoiTestData();
    
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            "42",
            42
        );
        yield return Case(
            "-042",
            -42
        );
        yield return Case(
            "1337c0d3",
            1337
        );
        yield return Case(
            "0-1",
            0
        );
        yield return Case(
            "words and 987",
            0
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(string s, int expectedResult)
        => [s, expectedResult];
}