using Solutions.Arrays.Easy;
using NUnit.Framework;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Test]
        [TestCaseSource(typeof(RemoveDuplicatesFromSortedArrayTestData))]
        public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
        {
            int expectedK = expectedNums.Length;
            int k = RemoveDuplicatesFromSortedArray.Solution(nums);
            Assert.That(k, Is.EqualTo(expectedK));
            Assert.That(expectedNums, Is.EqualTo(nums[..k]));
        }
    }
}
