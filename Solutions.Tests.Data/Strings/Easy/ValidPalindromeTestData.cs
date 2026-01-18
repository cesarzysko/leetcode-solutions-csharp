using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Strings.Easy;

public class ValidPalindromeTestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new ValidPalindromeTestData();
    
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            "A man, a plan, a canal: Panama",
            true
        );
        yield return Case(
            "race a car",
            false
        );
        yield return Case(
            " ",
            true
        );
        yield return Case(
            "1 2 34 .321",
            true
        );
        yield return Case(
            "Madam, I'm Adam",
            true
        );
        yield return Case(
            "!M@ad--am, I'\\m Ad#am/",
            true
        );
        yield return Case(
            "appbappa",
            false
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private static object[] Case(string s, bool expectedResult)
        => [s, expectedResult];
}