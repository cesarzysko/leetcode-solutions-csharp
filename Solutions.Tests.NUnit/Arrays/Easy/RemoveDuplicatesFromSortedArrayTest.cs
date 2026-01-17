using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy;

[TestFixture]
public class RemoveDuplicatesFromSortedArrayTest
{
    [Test]
    [TestCaseSource(typeof(RemoveDuplicatesFromSortedArrayTestData))]
    public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
    {
        int expectedK = expectedNums.Length;
        int k = RemoveDuplicatesFromSortedArray.Solution(nums);
        Assert.That(expectedK, Is.EqualTo(k));
        Assert.That(nums[..k], Is.EqualTo(expectedNums));
    }
}