public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int ptr=0;
        foreach(int item in nums)
        {
            if (item!=val)
            {
                nums[ptr]=item;
                ptr+=1;
            }
        }
        return ptr;
    }
}