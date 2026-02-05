namespace Solutions.Tests.XUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

public class ImplementStrStrTest
{
    [Theory]
    [ClassData(typeof(ImplementStrStrTestData))]
    public void Solution_ImplementStrStr_Test(string haystack, string needle, int expectedResult)
    {
        int actualResult = ImplementStrStr.Solution(haystack, needle);
        Assert.Equal(expectedResult, actualResult);
    }
}