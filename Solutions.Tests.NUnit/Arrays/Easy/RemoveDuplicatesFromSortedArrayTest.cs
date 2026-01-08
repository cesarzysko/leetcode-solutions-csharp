using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

using Solutions.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Test]
        [TestCaseSource(typeof(TestData))]
        public void Solution_RemoveDuplicates_Test(int[] nums, int[] expectedNums)
        {
            int expectedK = expectedNums.Length;
            int k = RemoveDuplicatesFromSortedArray.Solution(nums);
            Assert.That(k, Is.EqualTo(expectedK));
            Assert.That(expectedNums, Is.EqualTo(nums[..k]));
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
