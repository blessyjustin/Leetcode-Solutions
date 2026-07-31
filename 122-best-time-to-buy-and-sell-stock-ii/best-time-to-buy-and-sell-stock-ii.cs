public class Solution {
    public int MaxProfit(int[] prices) {
        int sum=0;
        for(int i=1;i<prices.Length;i++){
            if(prices[i]>prices[i-1]){
                sum+=(prices[i]-prices[i-1]);
            }
        }
        return sum;
    }
}