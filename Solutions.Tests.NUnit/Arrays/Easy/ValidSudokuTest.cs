using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy;

[TestFixture]
public class ValidSudokuTest
{
    [Test]
    [TestCaseSource(typeof(ValidSudokuTestData))]
    public void Solution_ValidSudoku_Test(char[][] board, bool expectedResult)
    {
        bool actualResult = ValidSudoku.Solution(board);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}