using NUnit.Framework;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class IntersectionOfTwoArraysIITest
    {
        [Test]
        [TestCaseSource(typeof(IntersectionOfTwoArraysIITestData))]
        public void Solution_Intersection_Test(int[] nums1, int[] nums2, int[] expectedIntersection)
        {
            int[] result = IntersectionOfTwoArraysII.Solution(nums1, nums2);

            int rK = result.Length;
            int eK = expectedIntersection.Length;
            Assert.That(rK, Is.EqualTo(eK));

            short[] counts = new short[1001];

            for (int i = 0; i < eK; ++i)
            {
                int value = expectedIntersection[i];
                ++counts[value];
            }

            for (int i = 0; i < rK; ++i)
            {
                int value = result[i];
                Assert.Multiple(() =>
                {
                    Assert.That(value, Is.InRange(0, 1000));
                    Assert.That(--counts[value], Is.GreaterThanOrEqualTo(0), $"Unexpected extra value \"{value}\".");
                });
            }
        }
    }
}
