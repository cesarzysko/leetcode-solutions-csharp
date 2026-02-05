namespace Solutions.Tests.XUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

public class ValidPalindromeTest
{
    [Theory]
    [ClassData(typeof(ValidPalindromeTestData))]
    public void Solution_ValidPalindrome_Test(string s, bool expectedResult)
    {
        bool actualResult = ValidPalindrome.Solution(s);
        Assert.Equal(expectedResult, actualResult);
    }
}