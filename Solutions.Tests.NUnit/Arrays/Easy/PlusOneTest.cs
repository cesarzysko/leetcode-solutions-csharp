using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy;

[TestFixture]
public sealed class PlusOneTest
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
            Assert.That(rK, Is.EqualTo(eK));
            Assert.That(result, Is.EqualTo(expectedDigits));
        });
    }
}