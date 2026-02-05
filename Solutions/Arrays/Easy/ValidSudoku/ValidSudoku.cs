// <copyright file="ValidSudoku.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

using System.Collections.Generic;

/// <summary>
/// Class implementing a solution to the "Valid Sudoku" LeetCode problem.
/// </summary>
public static class ValidSudoku
{
    /// <summary>
    /// Implementation of the "Valid Sudoku" LeetCode problem.
    /// </summary>
    /// <param name="board">The sudoku board for which the validation is performed.</param>
    /// <returns>Whether the given sudoku board is in a valid state.</returns>
    public static bool Solution(char[][] board)
    {
        for (int i = 0; i < 9; ++i)
        {
            if (!CheckRow(board, i))
            {
                return false;
            }

            if (!CheckCol(board, i))
            {
                return false;
            }

            if (!CheckBox(board, i))
            {
                return false;
            }
        }

        return true;
    }

    private static bool CheckRow(char[][] board, int row)
    {
        HashSet<char> present = [];

        for (int c = 0; c < 9; ++c)
        {
            char num = board[row][c];
            if (num == '.')
            {
                continue;
            }

            if (!present.Add(num))
            {
                return false;
            }
        }

        return true;
    }

    private static bool CheckCol(char[][] board, int col)
    {
        HashSet<char> present = [];

        for (int r = 0; r < 9; ++r)
        {
            char num = board[r][col];
            if (num == '.')
            {
                continue;
            }

            if (!present.Add(num))
            {
                return false;
            }
        }

        return true;
    }

    private static bool CheckBox(char[][] board, int boxIndex)
    {
        HashSet<char> present = [];

        int boxRow = boxIndex / 3;
        int boxCol = boxIndex - (boxRow * 3);
        int rowOffset = boxRow * 3;
        int colOffset = boxCol * 3;
        for (int r = rowOffset; r < rowOffset + 3; ++r)
        {
            for (int c = colOffset; c < colOffset + 3; ++c)
            {
                char num = board[r][c];
                if (num == '.')
                {
                    continue;
                }

                if (!present.Add(num))
                {
                    return false;
                }
            }
        }

        return true;
    }
}