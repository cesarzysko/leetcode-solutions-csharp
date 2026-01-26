using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.xUnit.Strings.Easy;

public class LongestCommonPrefixTest
{
    [Theory]
    [ClassData(typeof(LongestCommonPrefixTestData))]
    public void Solution_LongestCommonPrefix_Test(string[] strs, string expectedResult)
    {
        string actualResult = LongestCommonPrefix.Solution(strs);
        
        Assert.Equal(expectedResult, actualResult);
    }
}