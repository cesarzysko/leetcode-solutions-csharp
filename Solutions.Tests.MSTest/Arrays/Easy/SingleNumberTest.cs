namespace Solutions.Tests.MSTest.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestClass]
public sealed class SingleNumberTest
{
    [TestMethod]
    [FromTestData(typeof(SingleNumberTestData))]
    public void Solution_SingleNumber_Test(int[] nums, int expectedNum)
    {
        int result = SingleNumber.Solution(nums);
        Assert.AreEqual(expectedNum, result);
    }
}