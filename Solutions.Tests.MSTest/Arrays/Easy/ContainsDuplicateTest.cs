using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy;

[TestClass]
public sealed class ContainsDuplicateTest
{
    [TestMethod]
    [FromTestData(typeof(ContainsDuplicateTestData))]
    public void Solution_ContainsDuplicate_Test(int[] nums, bool expectedResult)
    {
        bool result = ContainsDuplicate.Solution(nums);
        Assert.AreEqual(expectedResult, result);
    }
}