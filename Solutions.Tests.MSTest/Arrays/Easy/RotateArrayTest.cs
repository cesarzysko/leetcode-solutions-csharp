using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class RotateArrayTest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
        {
            RotateArray.Solution(nums, k);
            CollectionAssert.AreEqual(expectedNums, nums);
        }
        
        public static IEnumerable<object[]> GetTestData()
        {
            yield return Case(
                new[] { 1, 2, 3, 4, 5 },
                0,
                new[] { 1, 2, 3, 4, 5 }
            );
            yield return Case(
                new[] { 1, 2, 3, 4, 5 },
                1,
                new[] { 5, 1, 2, 3, 4 }
            );
            yield return Case(
                new[] { 1, 2, 3, 4, 5 },
                5,
                new[] { 1, 2, 3, 4, 5 }
            );
            yield return Case(
                new[] { 1, 2, 3, 4, 5 },
                10,
                new[] { 1, 2, 3, 4, 5 }
            );
        }

        private static object[] Case(int[] nums, int k, int[] expectedNums)
            => new object[] { nums, k, expectedNums };
    }
}
