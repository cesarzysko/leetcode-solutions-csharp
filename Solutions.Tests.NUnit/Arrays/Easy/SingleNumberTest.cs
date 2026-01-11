using NUnit.Framework;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class SingleNumberTest
    {
        [Test]
        [TestCaseSource(typeof(SingleNumberTestData))]
        public void Solution_SingleNumber_Test(int[] nums, int expectedNum)
        {
            int result = SingleNumber.Solution(nums);
            Assert.That(expectedNum, Is.EqualTo(result));
        }
    }
}
