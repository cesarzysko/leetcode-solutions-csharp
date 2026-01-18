using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.NUnit.Strings.Easy;

[TestFixture]
public class ValidPalindromeTest
{
    [Test]
    [TestCaseSource(typeof(ValidPalindromeTestData))]
    public void Solution_ValidPalindrome_Test(string s, bool expectedResult)
    {
        bool result = ValidPalindrome.Solution(s);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}