using Solutions.Arrays.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [DataTestMethod]
        [DynamicData(
            nameof(RemoveDuplicatesFromSortedArrayTestData.GetTestData), 
            typeof(RemoveDuplicatesFromSortedArrayTestData),
            DynamicDataSourceType.Method
        )]
        public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
        {
            int expectedK = expectedNums.Length;
            int k = RemoveDuplicatesFromSortedArray.Solution(nums);
            Assert.AreEqual(expectedK, k);
            CollectionAssert.AreEqual(expectedNums, nums[..k]);
        }
    }
}
