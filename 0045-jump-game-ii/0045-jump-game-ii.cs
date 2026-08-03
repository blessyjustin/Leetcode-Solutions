public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length==1){
            return 0;
        }
        int count=0;
        int left=0;
        int right=0;
        while(right<nums.Length-1)
        {
            int farthest=0;
            for (int i=left;i<=right;i++)
            {
                farthest=Math.Max(farthest,(i+nums[i]));
            }
            left=right+1;
            right=farthest;
            count+=1;
        }
        return count;
    }
}