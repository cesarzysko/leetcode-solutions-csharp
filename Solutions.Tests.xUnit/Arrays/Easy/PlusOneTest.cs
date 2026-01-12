using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;
using Xunit;

namespace Solutions.Tests.xUnit.Arrays.Easy
{
    public class PlusOneTest
    {
        [Theory]
        [ClassData(typeof(PlusOneTestData))]
        public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
        {
            int[] result = PlusOne.Solution(digits);

            int rK = result.Length;
            int eK = expectedDigits.Length;
            Assert.Equal(eK, rK);
            Assert.Equal(expectedDigits, result);
        }
    }
}
