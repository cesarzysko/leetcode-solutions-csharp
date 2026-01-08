using Solutions.Arrays.Easy;
using System.Collections.Generic;
using Xunit;

namespace Solutions.Tests.xUnit.Arrays.Easy
{
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
        {
            int expectedK = expectedNums.Length;
            int k = RemoveDuplicatesFromSortedArray.Solution(nums);
            Assert.Equal(expectedK, k);
            Assert.Equal(nums[..k], expectedNums);
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
                new[] { 0 },
                new[] { 0 }
            );
        }

        private static object[] Case(int[] nums, int[] expectedNums)
            => new object[] { nums, expectedNums };
    }
}
