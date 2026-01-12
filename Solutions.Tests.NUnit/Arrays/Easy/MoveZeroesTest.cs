using NUnit.Framework;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class MoveZeroesTest
    {
        [Test]
        [TestCaseSource(typeof(MoveZeroesTestData))]
        public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
        {
            MoveZeroes.Solution(nums);

            int eK = expectedNums.Length;
            int rK = nums.Length;
            Assert.That(eK, Is.EqualTo(rK));
            Assert.That(expectedNums, Is.EqualTo(nums));
        }
    }
}
