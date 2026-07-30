public class Solution {
    public int MajorityElement(int[] nums) {
       int candidate=0;
       int count=0;

        foreach ( int item in nums)
        {
            if (count==0){
                candidate=item;
            }
            if(item==candidate){
                count+=1;
            }
            else
            {
                count-=1;
            }
        }
        return candidate;
        
    }
}