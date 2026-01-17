using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.MSTest.Strings.Easy;

[TestClass]
public sealed class FirstUniqueCharacterInAStringTest
{
    [TestMethod]
    [DynamicData(
        nameof(FirstUniqueCharacterInAStringTestData.GetTestData),
        typeof(FirstUniqueCharacterInAStringTestData)
    )]
    public void Solution_FirstUniqueChar_Test(string s, int expectedChIndex)
    {
        int chIndex = FirstUniqueCharacterInAString.Solution(s);
        Assert.AreEqual(expectedChIndex, chIndex);
    }
}