using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.MSTest.Strings.Easy;

[TestClass]
public class ValidPalindromeTest
{
    [TestMethod]
    [DynamicData(
        nameof(ValidPalindromeTestData.GetTestData),
        typeof(ValidPalindromeTestData)
    )]
    public void Solution_ValidPalindrome_Test(string s, bool expectedResult)
    {
        bool result = ValidPalindrome.Solution(s);
        Assert.AreEqual(expectedResult, result);
    }
}