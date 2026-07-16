public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0;
        int l = 0;
        int r = 1;

        for (int i = 0; i < prices.Length - 1; i++) {
            // profitable?
            if (prices[l] < prices[r]) {
                maxP = Math.Max(maxP, prices[r] - prices[l]);
            } else {
                l = r;
            }
            r++;
        }
        return maxP;
    }
}
