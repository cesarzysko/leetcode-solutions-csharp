using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.NUnit.Strings.Easy;

[TestFixture]
public sealed class FirstUniqueCharacterInAStringTest
{
    [Test]
    [TestCaseSource(typeof(FirstUniqueCharacterInAStringTestData))]
    public void Solution_FirstUniqueChar_Test(string s, int expectedChIndex)
    {
        int chIndex = FirstUniqueCharacterInAString.Solution(s);
        Assert.That(chIndex, Is.EqualTo(expectedChIndex));
    }
}