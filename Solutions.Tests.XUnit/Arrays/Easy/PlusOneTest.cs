namespace Solutions.Tests.XUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

public sealed class PlusOneTest
{
    [Theory]
    [ClassData(typeof(PlusOneTestData))]
    public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
    {
        int[] result = PlusOne.Solution(digits);
        int actualK = result.Length;
        int expectedK = expectedDigits.Length;
        Assert.Equal(expectedK, actualK);
        Assert.Equal(expectedDigits, result);
    }
}