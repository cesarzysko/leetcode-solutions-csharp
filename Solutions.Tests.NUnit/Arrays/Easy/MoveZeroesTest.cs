namespace Solutions.Tests.NUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestFixture]
public sealed class MoveZeroesTest
{
    [Test]
    [TestCaseSource(typeof(MoveZeroesTestData))]
    public void Solution_MoveZeroes_Test(int[] nums, int[] expectedNums)
    {
        MoveZeroes.Solution(nums);

        int expectedK = expectedNums.Length;
        int actualK = nums.Length;
        using (Assert.EnterMultipleScope())
        {
            Assert.That(actualK, Is.EqualTo(expectedK));
            Assert.That(nums, Is.EqualTo(expectedNums));
        }
    }
}