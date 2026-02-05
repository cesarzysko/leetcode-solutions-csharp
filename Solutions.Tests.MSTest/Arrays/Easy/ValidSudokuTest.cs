namespace Solutions.Tests.MSTest.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

[TestClass]
public sealed class ValidSudokuTest
{
    [TestMethod]
    [FromTestData(typeof(ValidSudokuTestData))]
    public void Solution_ValidSudoku_Test(char[][] board, bool expectedResult)
    {
        bool actualResult = ValidSudoku.Solution(board);
        Assert.AreEqual(expectedResult, actualResult);
    }
}