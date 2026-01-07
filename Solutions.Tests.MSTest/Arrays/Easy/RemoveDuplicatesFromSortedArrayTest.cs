using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Solutions.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
        {
            int expectedK = expectedNums.Length;
            int k = RemoveDuplicatesFromSortedArray.Solution(nums);
            Assert.AreEqual(k, expectedK);

            if (k == 0) return;

            CollectionAssert.AreEqual(expectedNums, nums[..k]);
        }
        
        public static IEnumerable<object[]> GetTestData()
        {
            yield return Case(
                new[] { 1, 1, 1, 2, 2, 3 }, 
                new[] { 1, 2, 3 }
            );
            yield return Case(
                new[] { 2, 2, 4, 5, 8, 11, 11, 11, 11, 15, 100 }, 
                new[] { 2, 4, 5, 8, 11, 15, 100 }
            );
            yield return Case(
                new[] { 4, 7, 9, 11, 13, 101 }, 
                new[] { 4, 7, 9, 11, 13, 101 }
            );
            yield return Case(
                Array.Empty<int>(), 
                Array.Empty<int>()
            );
            yield return Case(
                new[] { 0 }, 
                new[] { 0 }
            );
        }
        
        private static object[] Case(int[] nums, int[] expectedNums) => new object[] { nums, expectedNums };
    }
}
