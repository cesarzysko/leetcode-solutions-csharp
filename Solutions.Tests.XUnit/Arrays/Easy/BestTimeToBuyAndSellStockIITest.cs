namespace Solutions.Tests.XUnit.Arrays.Easy;

using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

public sealed class BestTimeToBuyAndSellStockIITest
{
    [Theory]
    [ClassData(typeof(BestTimeToBuyAndSellStocksIITestData))]
    public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
    {
        int actualProfit = BestTimeToBuyAndSellStockII.Solution(prices);
        Assert.Equal(expectedProfit, actualProfit);
    }
}