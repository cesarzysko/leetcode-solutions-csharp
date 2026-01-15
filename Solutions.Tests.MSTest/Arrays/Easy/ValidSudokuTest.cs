using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class ValidSudokuTest
    {
        [TestMethod]
        [DynamicData(
            nameof(ValidSudokuTestData.GetTestData),
            typeof(ValidSudokuTestData)
        )]
        public void Solution_ValidSudoku_Test(char[][] board, bool expectedResult)
        {
            bool actualResult = ValidSudoku.Solution(board);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
