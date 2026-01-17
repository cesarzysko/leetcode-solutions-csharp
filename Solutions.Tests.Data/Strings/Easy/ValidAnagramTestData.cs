using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Strings.Easy;

public class ValidAnagramTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new ValidAnagramTestData();
    
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            "turtle",
            "leturt",
            true
        );
        yield return Case(
            "anagram",
            "nagamam",
            false
        );
        yield return Case(
            "abba",
            "baab",
            true
        );
        yield return Case(
            "anagrram",
            "anagrramm",
            false
        );
        yield return Case(
            "anagramm",
            "anagrammm",
            false
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(string s, string t, bool expectedResult)
        => [s, t, expectedResult];
}