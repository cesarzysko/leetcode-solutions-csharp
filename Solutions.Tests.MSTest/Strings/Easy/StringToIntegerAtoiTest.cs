using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.MSTest.Strings.Easy;

[TestClass]
public class StringToIntegerAtoiTest
{
    [TestMethod]
    [DynamicData(
        nameof(StringToIntegerAtoiTestData.GetTestData),
        typeof(StringToIntegerAtoiTestData)
    )]
    public void Solution_StringToInteger_Test(string s, int expectedResult)
    {
        int result = StringToIntegerAtoi.Solution(s);
        Assert.AreEqual(expectedResult, result);
    }
}