namespace Solutions.Tests.NUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

[TestFixture]
public sealed class ReverseIntegerTest
{
    [Test]
    [TestCaseSource(typeof(ReverseIntegerTestData))]
    public void Solution_ReverseInteger_Test(int x, int expectedResult)
    {
        int actualResult = ReverseInteger.Solution(x);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}