namespace Solutions.Arrays.Easy;

public static class BestTimeToBuyAndSellStockII
{
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