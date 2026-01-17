using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy;

public class BestTimeToBuyAndSellStockIITest
{
    [Theory]
    [ClassData(typeof(BestTimeToBuyAndSellStocksIITestData))]
    public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
    {
        int result = BestTimeToBuyAndSellStockII.Solution(prices);
        Assert.Equal(expectedProfit, result);
    }
}