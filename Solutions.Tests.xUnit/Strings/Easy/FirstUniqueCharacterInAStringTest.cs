using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.xUnit.Strings.Easy;

public sealed class FirstUniqueCharacterInAStringTest
{
    [Theory]
    [ClassData(typeof(FirstUniqueCharacterInAStringTestData))]
    public void Solution_FirstUniqueChar_Test(string s, int expectedChIndex)
    {
        int chIndex = FirstUniqueCharacterInAString.Solution(s);
        Assert.Equal(expectedChIndex, chIndex);
    }
}