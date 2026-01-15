using System;

namespace Solutions.Arrays.Easy
{
    public static class RotateImage
    {
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
}
