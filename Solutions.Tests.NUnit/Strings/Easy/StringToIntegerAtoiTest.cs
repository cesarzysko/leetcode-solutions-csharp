using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.NUnit.Strings.Easy;

[TestFixture]
public class StringToIntegerAtoiTest
{
    [Test]
    [TestCaseSource(typeof(StringToIntegerAtoiTestData))]
    public void Solution_StringToInteger_Test(string s, int expectedResult)
    {
        int result = StringToIntegerAtoi.Solution(s);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}