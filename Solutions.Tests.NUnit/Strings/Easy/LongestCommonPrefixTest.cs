using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.NUnit.Strings.Easy;

[TestFixture]
public class LongestCommonPrefixTest
{
    [Test]
    [TestCaseSource(typeof(LongestCommonPrefixTestData))]
    public void Solution_LongestCommonPrefix_Test(string[] strs, string expectedResult)
    {
        string actualResult = LongestCommonPrefix.Solution(strs);
        
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}