using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

using Solutions.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy
{
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Theory]
        [ClassData(typeof(TestData))]
        public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
        {
            int expectedK = expectedNums.Length;
            int k = RemoveDuplicatesFromSortedArray.Solution(nums);
            Assert.Equal(expectedK, k);

            if (k == 0) return;
            
            Assert.Equal(nums[..k], expectedNums);
        }

        private class TestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
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

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            private static object[] Case(int[] nums, int[] expectedNums)
                => new object[] { nums, expectedNums };
        }
    }
}
