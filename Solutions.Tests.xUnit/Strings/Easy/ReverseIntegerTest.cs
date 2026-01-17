using Solutions.Strings.Easy;
using Solutions.Tests.Data.Strings.Easy;
using Xunit;

namespace Solutions.Tests.xUnit.Strings.Easy
{
    public class ReverseIntegerTest
    {
        [Theory]
        [ClassData(typeof(ReverseIntegerTestData))]
        public void Solution_ReverseInteger_Test(int x, int expectedResult)
        {
            int result = ReverseInteger.Solution(x);
            Assert.Equal(expectedResult, result);
        }
    }
}
