// <copyright file="BestTimeToBuyAndSellStockIITest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.XUnit.Arrays.Easy;

using BestTimeToBuyAndSellStockII = Solutions.Arrays.Easy.BestTimeToBuyAndSellStockII;
using BestTimeToBuyAndSellStocksIITestData = Solutions.Tests.Data.Arrays.Easy.BestTimeToBuyAndSellStocksIITestData;

/// <summary>
/// Class implementing tests logic for <see cref="BestTimeToBuyAndSellStockII"/>.
/// </summary>
public sealed class BestTimeToBuyAndSellStockIITest
{
    /// <summary>
    /// Tests whether the returned profit matches the expected profit.
    /// </summary>
    /// <param name="prices">Prices of stocks across days.</param>
    /// <param name="expectedProfit">Expected max profit from buying and selling stocks.</param>
    [Theory]
    [ClassData(typeof(BestTimeToBuyAndSellStocksIITestData))]
    public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
    {
        int actualProfit = BestTimeToBuyAndSellStockII.Solution(prices);
        Assert.Equal(expectedProfit, actualProfit);
    }
}
