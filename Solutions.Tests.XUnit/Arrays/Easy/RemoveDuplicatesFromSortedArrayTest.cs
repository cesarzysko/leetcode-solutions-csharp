namespace Solutions.Tests.XUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

public sealed class RemoveDuplicatesFromSortedArrayTest
{
    [Theory]
    [ClassData(typeof(RemoveDuplicatesFromSortedArrayTestData))]
    public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
    {
        int expectedK = expectedNums.Length;
        int actualK = RemoveDuplicatesFromSortedArray.Solution(nums);
        Assert.Equal(expectedK, actualK);
        Assert.Equal(nums[..actualK], expectedNums);
    }
}