using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy;

public sealed class RemoveDuplicatesFromSortedArrayTest
{
    [Theory]
    [ClassData(typeof(RemoveDuplicatesFromSortedArrayTestData))]
    public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
    {
        int expectedK = expectedNums.Length;
        int k = RemoveDuplicatesFromSortedArray.Solution(nums);
        Assert.Equal(expectedK, k);
        Assert.Equal(nums[..k], expectedNums);
    }
}