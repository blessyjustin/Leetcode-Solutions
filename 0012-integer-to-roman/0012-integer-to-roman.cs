public class Solution {
    public string IntToRoman(int num) {
        int [] values={1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string [] letter={"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
        string ans="";
        for(int i=0;i<values.Length;i++){
            while(num>=values[i]){
                ans+=letter[i];
                num=num-values[i];
            }
        }
        return ans;
    }
}