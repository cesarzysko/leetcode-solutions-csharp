namespace Solutions.Tests.XUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

public sealed class ReverseIntegerTest
{
    [Theory]
    [ClassData(typeof(ReverseIntegerTestData))]
    public void Solution_ReverseInteger_Test(int x, int expectedResult)
    {
        int actualResult = ReverseInteger.Solution(x);
        Assert.Equal(expectedResult, actualResult);
    }
}