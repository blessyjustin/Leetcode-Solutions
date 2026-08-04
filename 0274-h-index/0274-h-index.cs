public class Solution {
    public int HIndex(int[] citations) {
        int maxvalid=0;
        for(int h=1;h<=citations.Length;h++)
        {
            int count=0;
            for (int i=0;i<citations.Length;i++){
                if(citations[i]>=h)
                {
                    count+=1;
                }
            }
            if(count>=h)
            {
                maxvalid=Math.Max(maxvalid,h);
            }
        }
        return maxvalid;

    }
}