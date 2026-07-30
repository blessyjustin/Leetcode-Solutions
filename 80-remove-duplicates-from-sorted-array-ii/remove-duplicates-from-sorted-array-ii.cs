public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length<=2)
        return nums.Length;
        int ptr=2;
        for ( int i=2;i<nums.Length;i++)
        {
            if( nums[i]!=nums[ptr-2]){
                nums[ptr]=nums[i];
                ptr+=1;
            }
        }
        return ptr;
        
    }
}