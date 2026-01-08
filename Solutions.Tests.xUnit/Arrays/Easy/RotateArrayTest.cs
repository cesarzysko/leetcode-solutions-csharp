using System.Collections.Generic;
using Solutions.Arrays.Easy;
using Xunit;

namespace Solutions.Tests.xUnit.Arrays.Easy
{
    public class RotateArrayTest
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
        {
            RotateArray.Solution(nums, k);
            Assert.Equal(expectedNums, nums);
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
