namespace Solutions.Tests.MSTest.Strings.Easy;

using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

[TestClass]
public sealed class ReverseStringTest
{
    [TestMethod]
    [FromTestData(typeof(ReverseStringTestData))]
    public void Solution_ReverseString_Test(char[] text, char[] expectedText)
    {
        ReverseString.Solution(text);
        CollectionAssert.AreEqual(expectedText, text);
    }
}