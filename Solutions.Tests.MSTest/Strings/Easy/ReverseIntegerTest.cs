using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.MSTest.Strings.Easy;

[TestClass]
public sealed class ReverseIntegerTest
{
    [TestMethod]
    [FromTestData(typeof(ReverseIntegerTestData))]
    public void Solution_ReverseInteger_Test(int x, int expectedResult)
    {
        int result = ReverseInteger.Solution(x);
        Assert.AreEqual(expectedResult, result);
    }
}