public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left=0;
        int minlen=int.MaxValue;
        int sum=0;
        for(int right=0;right<nums.Length;right++)
        {
            sum+=nums[right];
            while(sum>=target)
            {
                minlen=Math.Min(right-left+1,minlen);
                sum-=nums[left];
                left++;
            }
        }
        return minlen==int.MaxValue?0:minlen;
    }
}