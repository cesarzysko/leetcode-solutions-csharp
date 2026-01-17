using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy;

[TestClass]
public sealed class RemoveDuplicatesFromSortedArrayTest
{
    [TestMethod]
    [DynamicData(
        nameof(RemoveDuplicatesFromSortedArrayTestData.GetTestData),
        typeof(RemoveDuplicatesFromSortedArrayTestData)
    )]
    public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
    {
        int expectedK = expectedNums.Length;
        int k = RemoveDuplicatesFromSortedArray.Solution(nums);
        Assert.AreEqual(expectedK, k);
        CollectionAssert.AreEqual(expectedNums, nums[..k]);
    }
}