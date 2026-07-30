public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int ptr=0;
        int count=1;
        for( int i=1;i<nums.Length;i++){
            if( nums[ptr]==nums[i]&& count<2 ){
                count+=1;
                ptr+=1;
                nums[ptr]=nums[i];
            }
            else if(nums[ptr]!=nums[i])
            {
                count=1;
                ptr+=1;
                nums[ptr]=nums[i];
            }
        }
        return ptr+1;
        
    }
}