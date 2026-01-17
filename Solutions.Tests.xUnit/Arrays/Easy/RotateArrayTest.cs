using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy;

public sealed class RotateArrayTest
{
    [Theory]
    [ClassData(typeof(RotateArrayTestData))]
    public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
    {
        RotateArray.Solution(nums, k);
        Assert.Equal(expectedNums, nums);
    }
}