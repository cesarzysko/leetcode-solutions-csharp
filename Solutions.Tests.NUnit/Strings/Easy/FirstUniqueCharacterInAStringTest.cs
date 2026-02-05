namespace Solutions.Tests.NUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

[TestFixture]
public sealed class FirstUniqueCharacterInAStringTest
{
    [Test]
    [TestCaseSource(typeof(FirstUniqueCharacterInAStringTestData))]
    public void Solution_FirstUniqueChar_Test(string s, int expectedChIndex)
    {
        int actualChIndex = FirstUniqueCharacterInAString.Solution(s);
        Assert.That(actualChIndex, Is.EqualTo(expectedChIndex));
    }
}