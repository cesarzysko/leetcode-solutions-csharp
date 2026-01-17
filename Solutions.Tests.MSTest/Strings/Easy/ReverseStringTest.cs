using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.MSTest.Strings.Easy;

[TestClass]
public sealed class ReverseStringTest
{
    [TestMethod]
    [DynamicData(
        nameof(ReverseStringTestData.GetTestData),
        typeof(ReverseStringTestData)
    )]
    public void Solution_ReverseString_Test(char[] text, char[] expectedText)
    {
        ReverseString.Solution(text);
        CollectionAssert.AreEqual(expectedText, text);
    }
}