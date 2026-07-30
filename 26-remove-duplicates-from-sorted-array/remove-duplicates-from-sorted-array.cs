public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int ptr=0;
        for( int i=1;i<nums.Length;i++)
        {
            if(nums[i]!=nums[ptr])
            {
                ptr+=1;
                nums[ptr]=nums[i];
            }
        }
        return ptr+1;
    }
}