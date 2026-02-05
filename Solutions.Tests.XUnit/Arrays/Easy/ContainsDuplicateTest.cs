namespace Solutions.Tests.XUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

public sealed class ContainsDuplicateTest
{
    [Theory]
    [ClassData(typeof(ContainsDuplicateTestData))]
    public void Solution_ContainsDuplicate_Test(int[] nums, bool expectedResult)
    {
        bool actualResult = ContainsDuplicate.Solution(nums);
        Assert.Equal(expectedResult, actualResult);
    }
}