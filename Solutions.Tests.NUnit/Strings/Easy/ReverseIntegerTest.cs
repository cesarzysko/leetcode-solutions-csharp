using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.NUnit.Strings.Easy;

[TestFixture]
public sealed class ReverseIntegerTest
{
    [Test]
    [TestCaseSource(typeof(ReverseIntegerTestData))]
    public void Solution_ReverseInteger_Test(int x, int expectedResult)
    {
        int result = ReverseInteger.Solution(x);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}