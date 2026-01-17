using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy;

public class SingleNumberTest
{
    [Theory]
    [ClassData(typeof(SingleNumberTestData))]
    public void Solution_SingleNumber_Test(int[] nums, int expectedNum)
    {
        int result = SingleNumber.Solution(nums);
        Assert.Equal(expectedNum, result);
    }
}