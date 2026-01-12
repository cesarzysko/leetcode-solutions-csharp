using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;
using Xunit;

namespace Solutions.Tests.xUnit.Arrays.Easy
{
    public class MoveZeroesTest
    {
        [Theory]
        [ClassData(typeof(MoveZeroesTestData))]
        public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
        {
            MoveZeroes.Solution(nums);

            int eK = expectedNums.Length;
            int rK = nums.Length;
            Assert.Equal(eK, rK);
            Assert.Equal(expectedNums, nums);
        }
    }
}
