using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class BestTimeToBuyAndSellStockIITest
    {
        [DataTestMethod]
        [DynamicData(
            nameof(BestTimeToBuyAndSellStocksIITestData.GetTestData), 
            typeof(BestTimeToBuyAndSellStocksIITestData)
        )]
        public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
        {
            int result = BestTimeToBuyAndSellStockII.Solution(prices);
            Assert.AreEqual(expectedProfit, result);
        }
    }
}
