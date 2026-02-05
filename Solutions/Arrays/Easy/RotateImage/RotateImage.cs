// <copyright file="RotateImage.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

using System;

/// <summary>
/// Class implementing a solution to the "Rotate Image" LeetCode problem.
/// </summary>
public static class RotateImage
{
    /// <summary>
    /// Implementation of the "Rotate Image" LeetCode problem.
    /// </summary>
    /// <param name="matrix">The N by N number array to be rotated by 90 degrees clockwise.</param>
    public static void Solution(int[][] matrix)
    {
        int n = matrix.Length;
        for (int r = 0; r < n; ++r)
        {
            for (int c = r + 1; c < n; ++c)
            {
                int temp = matrix[r][c];
                matrix[r][c] = matrix[c][r];
                matrix[c][r] = temp;
            }
        }

        for (int r = 0; r < n; ++r)
        {
            Array.Reverse(matrix[r]);
        }
    }
}
