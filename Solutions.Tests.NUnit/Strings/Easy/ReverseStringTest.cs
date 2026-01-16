using NUnit.Framework;
using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;

namespace Solutions.Tests.NUnit.Strings.Easy
{
    [TestFixture]
    public class ReverseStringTest
    {
        [Test]
        [TestCaseSource(typeof(ReverseStringTestData))]
        public void Solution_ReverseString_Test(char[] text, char[] expectedText)
        {
            ReverseString.Solution(text);
            Assert.That(text, Is.EqualTo(expectedText));
        }
    }
}
