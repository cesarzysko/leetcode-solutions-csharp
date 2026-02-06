// <copyright file="ValidSudokuTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Arrays.Easy;

using ValidSudoku = Solutions.Arrays.Easy.ValidSudoku;
using ValidSudokuTestData = Solutions.Tests.Data.Arrays.Easy.ValidSudokuTestData;

/// <summary>
/// Class implementing tests logic for <see cref="ValidSudoku"/>.
/// </summary>
public sealed class ValidSudokuTest
{
    /// <summary>
    /// Tests whether the solution correctly detects if the given sudoku board is in a correct state.
    /// </summary>
    /// <param name="board">The sudoku board state.</param>
    /// <param name="expectedResult">The expected result.</param>
    [Theory]
    [ClassData(typeof(ValidSudokuTestData))]
    public void Solution_ValidSudoku_Test(char[][] board, bool expectedResult)
    {
        bool actualResult = ValidSudoku.Solution(board);
        Assert.Equal(expectedResult, actualResult);
    }
}
