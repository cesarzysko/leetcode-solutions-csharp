// <copyright file="BestTimeToBuyAndSellStockII.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

/// <summary>
/// Class implementing a solution to the "Best Time to Buy and Sell Stock II" LeetCode problem.
/// </summary>
public static class BestTimeToBuyAndSellStockII
{
    /// <summary>
    /// Implementation of the "Best Time to Buy and Sell Stock II" LeetCode problem.
    /// </summary>
    /// <param name="prices">The price of the stock across days.</param>
    /// <returns>The maximum profit.</returns>
    public static int Solution(int[] prices)
    {
        int pricesCount = prices.Length;
        int profit = 0;
        for (int i = 1; i < pricesCount; ++i)
        {
            if (prices[i - 1] < prices[i])
            {
                profit += prices[i] - prices[i - 1];
            }
        }

        return profit;
    }
}
