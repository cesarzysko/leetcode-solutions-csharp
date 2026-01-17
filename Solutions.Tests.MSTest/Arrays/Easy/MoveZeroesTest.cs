using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy;

[TestClass]
public class MoveZeroesTest
{
    [TestMethod]
    [DynamicData(
        nameof(MoveZeroesTestData.GetTestData),
        typeof(MoveZeroesTestData)
    )]
    public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
    {
        MoveZeroes.Solution(nums);

        int eK = expectedNums.Length;
        int rK = nums.Length;
        Assert.AreEqual(eK, rK);
        CollectionAssert.AreEqual(expectedNums, nums);
    }
}