namespace Solutions.Tests.NUnit.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

[TestFixture]
public class ValidAnagramTest
{
    [Test]
    [TestCaseSource(typeof(ValidAnagramTestData))]
    public void Solution_ValidAnagram_Test(string s, string t, bool expectedResult)
    {
        bool firstResult = ValidAnagram.Solution(s, t);
        bool secondResult = ValidAnagram.Solution(t, s);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(firstResult, Is.EqualTo(expectedResult));
            Assert.That(secondResult, Is.EqualTo(expectedResult));
        }
    }
}