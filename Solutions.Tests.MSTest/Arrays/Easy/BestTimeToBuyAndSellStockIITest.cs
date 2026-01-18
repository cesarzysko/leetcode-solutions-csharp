using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy;

[TestClass]
public sealed class BestTimeToBuyAndSellStockIITest
{
    [TestMethod]
    [FromTestData(typeof(BestTimeToBuyAndSellStocksIITestData))]
    public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
    {
        int result = BestTimeToBuyAndSellStockII.Solution(prices);
        Assert.AreEqual(expectedProfit, result);
    }
}