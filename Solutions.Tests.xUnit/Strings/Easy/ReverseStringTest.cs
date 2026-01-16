using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;
using Xunit;

namespace Solutions.Tests.xUnit.Strings.Easy
{
    public class ReverseStringTest
    {
        [Theory]
        [ClassData(typeof(ReverseStringTestData))]
        public void Solution_ReverseString_Test(char[] text, char[] expectedText)
        {
            ReverseString.Solution(text);
            Assert.Equal(expectedText, text);
        }
    }
}
