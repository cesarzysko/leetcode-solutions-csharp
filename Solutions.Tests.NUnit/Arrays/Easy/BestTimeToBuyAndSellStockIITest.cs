using Solutions.Arrays.Easy;
using System.Collections.Generic;
using NUnit.Framework;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class BestTimeToBuyAndSellStockIITest
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
        {
            int result = BestTimeToBuyAndSellStockII.Solution(prices);
            Assert.That(expectedProfit, Is.EqualTo(result));
        }
        
        private static IEnumerable<object[]> GetTestData()
        {
            yield return Case(
                new[] { 1, 2, 3, 4, 5 }, 
                4
            );
            yield return Case(
                new[] { 5, 1, 5 }, 
                4
            );
            yield return Case(
                new[] { 5, 5, 5, 5, 5, 2, 1 }, 
                0
            );
            yield return Case(
                new[] { 5, 5, 3, 5, 5, 2, 3, 4, 1, 0 }, 
                4
            );
        }

        private static object[] Case(int[] prices, int expectedProfit)
            => new object[] { prices, expectedProfit };
    }
}
