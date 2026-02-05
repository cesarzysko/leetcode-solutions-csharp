namespace Solutions.Tests.NUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

[TestFixture]
public class LongestCommonPrefixTest
{
    [Test]
    [TestCaseSource(typeof(LongestCommonPrefixTestData))]
    public void Solution_LongestCommonPrefix_Test(string[] strings, string expectedResult)
    {
        string actualResult = LongestCommonPrefix.Solution(strings);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}