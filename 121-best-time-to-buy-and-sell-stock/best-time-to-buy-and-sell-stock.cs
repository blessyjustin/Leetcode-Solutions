public class Solution {
    public int MaxProfit(int[] prices) {
        int buy=prices[0];
        int maxProfit=0;

        foreach(int item in prices){
            if(item<=buy){
                buy=item;
            }
            else{
                maxProfit=Math.Max(maxProfit,item-buy);
            }
        }
        return maxProfit;
    }
}