using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;
using Xunit;

namespace Solutions.Tests.xUnit.Arrays.Easy
{
    public class ContainsDuplicateTest
    {
        [Theory]
        [ClassData(typeof(ContainsDuplicateTestData))]
        public void Solution_ContainsDuplicate_Test(int[] nums, bool expectedResult)
        {
            bool result = ContainsDuplicate.Solution(nums);
            Assert.Equal(expectedResult, result);
        }
    }
}
