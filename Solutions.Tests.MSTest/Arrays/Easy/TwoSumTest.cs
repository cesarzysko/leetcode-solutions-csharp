using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy;

[TestClass]
public sealed class TwoSumTest
{
    [TestMethod]
    [DynamicData(
        nameof(TwoSumTestData.GetTestData),
        typeof(TwoSumTestData)
    )]
    public void Solution_TwoSum_Test(int[] nums, int target, int[] expectedResult)
    {
        int[] actualResult = TwoSum.Solution(nums, target);
        Assert.HasCount(2, actualResult);
        CollectionAssert.AreEqual(expectedResult, actualResult);
            
        int actualTarget = nums[actualResult[0]] + nums[actualResult[1]];
        Assert.AreEqual(target, actualTarget);
    }
}