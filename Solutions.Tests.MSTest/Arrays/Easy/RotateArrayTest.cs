namespace Solutions.Tests.MSTest.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestClass]
public sealed class RotateArrayTest
{
    [TestMethod]
    [FromTestData(typeof(RotateArrayTestData))]
    public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
    {
        RotateArray.Solution(nums, k);
        CollectionAssert.AreEqual(expectedNums, nums);
    }
}