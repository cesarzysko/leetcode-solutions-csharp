using NUnit.Framework;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class TwoSumTest
    {
        [Test]
        [TestCaseSource(typeof(TwoSumTestData))]
        public void Solution_TwoSum_Test(int[] nums, int target, int[] expectedResult)
        {
            int[] actualResult = TwoSum.Solution(nums, target);
            Assert.That(actualResult, Has.Length.EqualTo(2));
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            
            int actualTarget = nums[actualResult[0]] + nums[actualResult[1]];
            Assert.That(actualTarget, Is.EqualTo(target));
        }
    }
}
