using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class RotateArrayTest
    {
        [TestMethod]
        [DynamicData(
            nameof(RotateArrayTestData.GetTestData),
            typeof(RotateArrayTestData)
        )]
        public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
        {
            RotateArray.Solution(nums, k);
            CollectionAssert.AreEqual(expectedNums, nums);
        }
    }
}
