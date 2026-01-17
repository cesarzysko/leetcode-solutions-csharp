using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Strings.Easy;

public sealed class FirstUniqueCharacterInAStringTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new FirstUniqueCharacterInAStringTestData();
    
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            "a",
            'a'
        );
        yield return Case(
            "aba",
            'b'
        );
        yield return Case(
            "abcdefghijklmnopqrstuwvyzabcdefghijklmnopqrstuwyz",
            'v'
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(string s, char uniqueCh)
        => [s, s.IndexOf(uniqueCh)];
}