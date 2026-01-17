using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy;

public sealed class RotateImageTest
{
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