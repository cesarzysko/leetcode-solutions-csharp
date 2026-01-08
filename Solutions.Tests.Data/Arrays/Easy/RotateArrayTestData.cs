using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy
{
    public class RotateArrayTestData : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetTestData()
            => new RotateArrayTestData();

        public IEnumerator<object[]> GetEnumerator()
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

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static object[] Case(int[] nums, int k, int[] expectedNums)
            => new object[] { nums, k, expectedNums };
    }
}