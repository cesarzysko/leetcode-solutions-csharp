namespace Solutions.Tests.NUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestFixture]
public sealed class PlusOneTest
{
    [Test]
    [TestCaseSource(typeof(PlusOneTestData))]
    public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
    {
        int[] actualDigits = PlusOne.Solution(digits);

        int actualK = actualDigits.Length;
        int expectedK = expectedDigits.Length;
        using (Assert.EnterMultipleScope())
        {
            Assert.That(actualK, Is.EqualTo(expectedK));
            Assert.That(actualDigits, Is.EqualTo(expectedDigits));
        }
    }
}