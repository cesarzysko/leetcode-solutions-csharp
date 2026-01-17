using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Strings.Easy;

public class ReverseStringTestData : IEnumerable<object[]>
{
    public static IEnumerable<object> GetTestData()
        => new ReverseStringTestData();
        
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            "abba",
            "abba"
        );
        yield return Case(
            "dada",
            "adad"
        );
        yield return Case(
            "abcdefghijk",
            "kjihgfedcba"
        );
        yield return Case(
            "12#90*.\\$@",
            "@$\\.*09#21"
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    private static object[] Case(string text, string expectedText)
        => [text.ToCharArray(), expectedText.ToCharArray()];
}