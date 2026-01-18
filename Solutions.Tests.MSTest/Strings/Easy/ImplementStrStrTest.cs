using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.MSTest.Strings.Easy;

[TestClass]
public class ImplementStrStrTest
{
    [TestMethod]
    [FromTestData(typeof(ImplementStrStrTestData))]
    public void Solution_ImplementStrStr_Test(string haystack, string needle, int expectedResult)
    {
        int actualResult = ImplementStrStr.Solution(haystack, needle);
        Assert.AreEqual(expectedResult, actualResult);
    }
}