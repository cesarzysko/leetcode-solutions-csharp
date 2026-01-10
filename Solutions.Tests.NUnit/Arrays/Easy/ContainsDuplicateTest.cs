using NUnit.Framework;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class ContainsDuplicateTest
    {
        [Test]
        [TestCaseSource(typeof(ContainsDuplicateTestData))]
        public void Solution_ContainsDuplicate_Test(int[] nums, bool expectedResult)
        {
            bool result = ContainsDuplicate.Solution(nums);
            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}
