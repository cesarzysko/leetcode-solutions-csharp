namespace Solutions.Tests.XUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

public sealed class MoveZeroesTest
{
    [Theory]
    [ClassData(typeof(MoveZeroesTestData))]
    public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
    {
        MoveZeroes.Solution(nums);
        int expectedK = expectedNums.Length;
        int actualK = nums.Length;
        Assert.Equal(expectedK, actualK);
        Assert.Equal(expectedNums, nums);
    }
}