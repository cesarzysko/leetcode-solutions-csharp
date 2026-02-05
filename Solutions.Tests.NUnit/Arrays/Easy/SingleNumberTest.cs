namespace Solutions.Tests.NUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestFixture]
public sealed class SingleNumberTest
{
    [Test]
    [TestCaseSource(typeof(SingleNumberTestData))]
    public void Solution_SingleNumber_Test(int[] nums, int expectedNum)
    {
        int actualNum = SingleNumber.Solution(nums);
        Assert.That(actualNum, Is.EqualTo(expectedNum));
    }
}