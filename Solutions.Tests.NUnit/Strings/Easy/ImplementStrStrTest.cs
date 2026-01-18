using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.NUnit.Strings.Easy;

[TestFixture]
public class ImplementStrStrTest
{
    [Test]
    [TestCaseSource(typeof(ImplementStrStrTestData))]
    public void Solution_ImplementStrStr_Test(string haystack, string needle, int expectedResult)
    {
        int actualResult = ImplementStrStr.Solution(haystack, needle);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}