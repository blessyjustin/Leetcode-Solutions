public class Solution {
    public int MaxProfit(int[] prices) {
        int ptr1=prices.Length-1;
        int ptr2=prices.Length-2;
        int sum=0;
        while(ptr1>0){
        if(prices[ptr1]>prices[ptr2])
        {
            sum+=(prices[ptr1]-prices[ptr2]);
        }
        ptr1-=1;
        ptr2-=1;
        }
        return sum;
    }
}