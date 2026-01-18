using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy;

[TestClass]
public sealed class PlusOneTest
{
    [TestMethod]
    [FromTestData(typeof(PlusOneTestData))]
    public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
    {
        int[] result = PlusOne.Solution(digits);

        int rK = result.Length;
        int eK = expectedDigits.Length;
        Assert.AreEqual(eK, rK);
        CollectionAssert.AreEqual(expectedDigits, result);
    }
}