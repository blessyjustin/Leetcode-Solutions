public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int []ans=new int[nums.Length];
        ans[0]=1;
        int post=1;
        for(int i =1;i<nums.Length;i++)
        {
            ans[i]=ans[i-1]*nums[i-1];
        }
        for(int i=nums.Length-2;i>=0;i--)
        {
            post=post*nums[i+1];
            ans[i]=ans[i]*post;
        }
        
        return ans;
    }
}