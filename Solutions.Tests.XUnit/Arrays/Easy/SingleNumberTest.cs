namespace Solutions.Tests.XUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

public sealed class SingleNumberTest
{
    [Theory]
    [ClassData(typeof(SingleNumberTestData))]
    public void Solution_SingleNumber_Test(int[] nums, int expectedNum)
    {
        int result = SingleNumber.Solution(nums);
        Assert.Equal(expectedNum, result);
    }
}