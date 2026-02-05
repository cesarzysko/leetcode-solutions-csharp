namespace Solutions.Tests.MSTest.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

[TestClass]
public class ValidAnagramTest
{
    [TestMethod]
    [FromTestData(typeof(ValidAnagramTestData))]
    public void Solution_ValidAnagram_Test(string s, string t, bool expectedResult)
    {
        bool firstResult = ValidAnagram.Solution(s, t);
        bool secondResult = ValidAnagram.Solution(t, s);

        Assert.AreEqual(expectedResult, firstResult);
        Assert.AreEqual(expectedResult, secondResult);
    }
}