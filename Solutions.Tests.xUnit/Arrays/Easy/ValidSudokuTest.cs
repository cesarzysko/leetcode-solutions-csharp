using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;
using Xunit;

namespace Solutions.Tests.xUnit.Arrays.Easy
{
    public class ValidSudokuTest
    {
        [Theory]
        [ClassData(typeof(ValidSudokuTestData))]
        public void Solution_ValidSudoku_Test(char[][] board, bool expectedResult)
        {
            bool actualResult = ValidSudoku.Solution(board);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
