namespace Solutions.Tests.NUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestFixture]
public sealed class RemoveDuplicatesFromSortedArrayTest
{
    [Test]
    [TestCaseSource(typeof(RemoveDuplicatesFromSortedArrayTestData))]
    public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
    {
        int expectedK = expectedNums.Length;
        int actualK = RemoveDuplicatesFromSortedArray.Solution(nums);
        using (Assert.EnterMultipleScope())
        {
            Assert.That(actualK, Is.EqualTo(expectedK));
            Assert.That(nums[..actualK], Is.EqualTo(expectedNums));
        }
    }
}