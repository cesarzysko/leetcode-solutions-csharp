using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.xUnit.Strings.Easy;

public class StringToIntegerAtoiTest
{
    [Theory]
    [ClassData(typeof(StringToIntegerAtoiTestData))]
    public void Solution_StringToInteger_Test(string s, int expectedResult)
    {
        int result = StringToIntegerAtoi.Solution(s);
        Assert.Equal(expectedResult, result);
    }
}