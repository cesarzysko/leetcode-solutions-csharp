using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy;

[TestFixture]
public class RotateImageTest
{
    [Test]
    [TestCaseSource(typeof(RotateImageTestData))]
    public void Solution_RotateImage_Test(int[][] matrix, int[][] expectedMatrix)
    {
        RotateImage.Solution(matrix);
        int n = matrix.Length;
        for (int i = 0; i < n; ++i)
        {
            Assert.That(matrix[i], Is.EqualTo(expectedMatrix[i]));
        }
    }
}