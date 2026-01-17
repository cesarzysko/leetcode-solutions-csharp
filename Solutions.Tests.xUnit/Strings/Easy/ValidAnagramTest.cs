using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.xUnit.Strings.Easy;

public class ValidAnagramTest
{
    [Theory]
    [ClassData(typeof(ValidAnagramTestData))]
    public void Solution_ValidAnagram_Test(string s, string t, bool expectedResult)
    {
        bool firstResult = ValidAnagram.Solution(s, t);
        bool secondResult = ValidAnagram.Solution(t, s);
        
        Assert.Equal(expectedResult, firstResult);
        Assert.Equal(expectedResult, secondResult);
    }
}