namespace Solutions.Tests.XUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

public sealed class TwoSumTest
{
    [Theory]
    [ClassData(typeof(TwoSumTestData))]
    public void Solution_TwoSum_Test(int[] nums, int target, int[] expectedResult)
    {
        int[] actualResult = TwoSum.Solution(nums, target);
        Assert.Equal(2, actualResult.Length);
        Assert.Equal(expectedResult, actualResult);

        int actualTarget = nums[actualResult[0]] + nums[actualResult[1]];
        Assert.Equal(target, actualTarget);
    }
}