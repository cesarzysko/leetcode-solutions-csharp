using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy
{
    public class ContainsDuplicateTestData : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetTestData()
            => new ContainsDuplicateTestData();

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return Case(
                new[] { 1, 2, 3, 4, 5 },
                false
            );
            yield return Case(
                new[] { 1, 4, 3, 10, 5 },
                false
            );
            yield return Case(
                new[] { 1 },
                false
            );
            yield return Case(
                new[] { 1, 1 },
                true
            );
            yield return Case(
                new[] { 1, 0, 3, 1, 9 },
                true
            );
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static object[] Case(int[] nums, bool expectedResult)
            => new object[] { nums, expectedResult };
    }
}
