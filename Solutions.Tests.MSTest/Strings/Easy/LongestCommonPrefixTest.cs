namespace Solutions.Tests.MSTest.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

[TestClass]
public class LongestCommonPrefixTest
{
    [TestMethod]
    [FromTestData(typeof(LongestCommonPrefixTestData))]
    public void Solution_LongestCommonPrefix_Test(string[] strings, string expectedResult)
    {
        string actualResult = LongestCommonPrefix.Solution(strings);

        Assert.AreEqual(expectedResult, actualResult);
    }
}