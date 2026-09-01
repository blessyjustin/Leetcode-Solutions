public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i=0;
        int j=i+1;
        int diff=target-numbers[i];
        while(i<j)
        {
            if(j>numbers.Length-1)
            {
                i++;
                j=i+1;
                diff=target-numbers[i];
            }
            if(numbers[j]!=diff)
            {
                j++;
            }
            else
            {
                break;
            }
        }
        return [i+1,j+1];
    }
}