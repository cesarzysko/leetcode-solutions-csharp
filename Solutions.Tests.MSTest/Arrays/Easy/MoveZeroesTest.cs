namespace Solutions.Tests.MSTest.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestClass]
public sealed class MoveZeroesTest
{
    [TestMethod]
    [FromTestData(typeof(MoveZeroesTestData))]
    public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
    {
        MoveZeroes.Solution(nums);

        int eK = expectedNums.Length;
        int rK = nums.Length;
        Assert.AreEqual(eK, rK);
        CollectionAssert.AreEqual(expectedNums, nums);
    }
}