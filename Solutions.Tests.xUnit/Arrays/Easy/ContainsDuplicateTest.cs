using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy;

public sealed class ContainsDuplicateTest
{
    [Theory]
    [ClassData(typeof(ContainsDuplicateTestData))]
    public void Solution_ContainsDuplicate_Test(int[] nums, bool expectedResult)
    {
        bool result = ContainsDuplicate.Solution(nums);
        Assert.Equal(expectedResult, result);
    }
}