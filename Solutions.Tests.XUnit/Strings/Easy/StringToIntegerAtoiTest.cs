namespace Solutions.Tests.XUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

public class StringToIntegerAtoiTest
{
    [Theory]
    [ClassData(typeof(StringToIntegerAtoiTestData))]
    public void Solution_StringToInteger_Test(string s, int expectedResult)
    {
        int actualResult = StringToIntegerAtoi.Solution(s);
        Assert.Equal(expectedResult, actualResult);
    }
}