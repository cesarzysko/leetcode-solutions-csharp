using NUnit.Framework;
using Solutions.Arrays.Easy.PlusOne;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class PlusOneTest
    {
        [Test]
        [TestCaseSource(typeof(PlusOneTestData))]
        public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
        {
            int[] result = PlusOne.Solution(digits);

            int rK = result.Length;
            int eK = expectedDigits.Length;
            Assert.Multiple(() =>
            {
                Assert.That(eK, Is.EqualTo(rK));
                Assert.That(expectedDigits, Is.EqualTo(result));
            });
        }
    }
}
