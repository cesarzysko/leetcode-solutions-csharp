using NUnit.Framework;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class RotateArrayTest
    {
        [Test]
        [TestCaseSource(typeof(RotateArrayTestData))]
        public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
        {
            RotateArray.Solution(nums, k);
            Assert.That(nums, Is.EqualTo(expectedNums));
        }
    }
}
