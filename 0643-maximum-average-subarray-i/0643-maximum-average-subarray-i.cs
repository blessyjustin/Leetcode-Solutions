public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int sum=0;
        int maxsum=0;
        for(int i=0;i<k;i++){
            sum+=nums[i];
        }
        maxsum=sum;
        for(int i=k;i<nums.Length;i++)
        {
            sum+=nums[i]-nums[i-k];
            maxsum=Math.Max(maxsum,sum);
        }
        return (double)maxsum/k;
    }
}