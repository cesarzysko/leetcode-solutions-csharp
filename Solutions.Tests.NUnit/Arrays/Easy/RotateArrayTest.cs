using System.Collections.Generic;
using NUnit.Framework;
using Solutions.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class RotateArrayTest
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void Solution_RotateArray_Test(int[] nums, int k, int[] expectedNums)
        {
            RotateArray.Solution(nums, k);
            Assert.That(expectedNums, Is.EqualTo(nums));
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
