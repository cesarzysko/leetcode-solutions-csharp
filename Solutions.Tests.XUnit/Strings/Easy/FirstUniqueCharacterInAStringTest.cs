namespace Solutions.Tests.XUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

public sealed class FirstUniqueCharacterInAStringTest
{
    [Theory]
    [ClassData(typeof(FirstUniqueCharacterInAStringTestData))]
    public void Solution_FirstUniqueChar_Test(string s, int expectedChIndex)
    {
        int actualChIndex = FirstUniqueCharacterInAString.Solution(s);
        Assert.Equal(expectedChIndex, actualChIndex);
    }
}