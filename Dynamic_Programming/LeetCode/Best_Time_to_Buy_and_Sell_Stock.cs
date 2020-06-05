using System;
namespace Dynamic_Programming.LeetCode
{
    public class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            var minPrice = int.MaxValue;
            var maxProfit = 0;
            foreach (var price in prices)
            {
                minPrice = Math.Min(minPrice, price);
                maxProfit = Math.Max(maxProfit, price - minPrice);
            }
            return maxProfit;
        }
    }
}