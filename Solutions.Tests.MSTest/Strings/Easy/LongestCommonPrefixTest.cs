using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.MSTest.Strings.Easy;

[TestClass]
public class LongestCommonPrefixTest
{
    [TestMethod]
    [FromTestData(typeof(LongestCommonPrefixTestData))]
    public void Solution_LongestCommonPrefix_Test(string[] strs, string expectedResult)
    {
        string actualResult = LongestCommonPrefix.Solution(strs);
        
        Assert.AreEqual(expectedResult, actualResult);
    }
}