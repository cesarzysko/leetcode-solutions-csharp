using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.xUnit.Strings.Easy;

public class ValidPalindromeTest
{
    [Theory]
    [ClassData(typeof(ValidPalindromeTestData))]
    public void Solution_ValidPalindrome_Test(string s, bool expectedResult)
    {
        bool result = ValidPalindrome.Solution(s);
        Assert.Equal(expectedResult, result);
    }
}