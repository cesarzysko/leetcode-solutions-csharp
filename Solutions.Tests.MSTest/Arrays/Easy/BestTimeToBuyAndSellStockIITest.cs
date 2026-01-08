using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class BestTimeToBuyAndSellStockIITest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
        {
            int result = BestTimeToBuyAndSellStockII.Solution(prices);
            Assert.AreEqual(expectedProfit, result);
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