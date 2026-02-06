// <copyright file="RotateImageTest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Arrays.Easy;

using RotateImage = Solutions.Arrays.Easy.RotateImage;
using RotateImageTestData = Solutions.Tests.Data.Arrays.Easy.RotateImageTestData;

/// <summary>
/// Class implementing tests logic for <see cref="RotateImage"/>.
/// </summary>
public sealed class RotateImageTest
{
    /// <summary>
    /// Tests whether the solution correctly rotates a square matrix by 90 degrees clockwise.
    /// </summary>
    /// <param name="matrix">The matrix to rotate.</param>
    /// <param name="expectedMatrix">The expected result.</param>
    [Theory]
    [ClassData(typeof(RotateImageTestData))]
    public void Solution_RotateImage_Test(int[][] matrix, int[][] expectedMatrix)
    {
        RotateImage.Solution(matrix);
        int n = matrix.Length;
        for (int i = 0; i < n; ++i)
        {
            Assert.Equal(expectedMatrix[i], matrix[i]);
        }
    }
}
