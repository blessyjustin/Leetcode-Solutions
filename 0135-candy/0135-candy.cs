public class Solution {
    public int Candy(int[] ratings) {
        int [] ar=new int[ratings.Length];
        Array.Fill(ar,1);
        for(int i=1;i<ratings.Length;i++)
        {
            if(ratings[i]>ratings[i-1]){
                ar[i]=ar[i-1]+1;
            }
        }
        for(int i=ratings.Length-2;i>=0;i--){
            if(ratings[i]>ratings[i+1]){
                if(ar[i]<=ar[i+1]){
                ar[i]=ar[i+1]+1;}
            }
        }
        return ar.Sum();
        
    }
}