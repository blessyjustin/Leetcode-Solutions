public class Solution {
    public int Trap(int[] height) {
        int left=0;
        int right=height.Length-1;
        int sum=0;
        int maxleft=height[left];
        int maxright=height[right];
        while(left<right){
            if(maxleft<maxright){
                left++;
                maxleft=Math.Max(maxleft,height[left]);
                sum+=maxleft-height[left];
            }
            else{
                right--;
                maxright=Math.Max(maxright,height[right]);
                sum+=maxright-height[right];
            }
        }
        return sum;

        
    }
}