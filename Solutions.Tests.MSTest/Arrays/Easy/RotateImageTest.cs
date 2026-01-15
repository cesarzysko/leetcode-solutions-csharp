using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class RotateImageTest
    {
        [TestMethod]
        [DynamicData(
            nameof(RotateImageTestData.GetTestData),
            typeof(RotateImageTestData)
        )]
        public void Solution_RotateImage_Test(int[][] matrix, int[][] expectedMatrix)
        {
            RotateImage.Solution(matrix);
            int n = matrix.Length;
            for (int i = 0; i < n; ++i)
            {
                CollectionAssert.AreEqual(expectedMatrix[i], matrix[i]);
            }
        }
    }
}
