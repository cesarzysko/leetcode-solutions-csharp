using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy
{
    public class RemoveDuplicatesFromSortedArrayTestData : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetTestData()
            => new RemoveDuplicatesFromSortedArrayTestData();

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
                new[] { 0 }, 
                new[] { 0 }
            );
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        private static object[] Case(int[] nums, int[] expectedNums) 
            => new object[] { nums, expectedNums };
    }
}