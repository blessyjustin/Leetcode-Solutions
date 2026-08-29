public class Solution {
    public int LengthOfLastWord(string s) {
        int count=0;
        s=s.TrimEnd();
        if(s.Length==1){
            return 1;
        }
        int ptr=s.Length-1;
        while(ptr>=0&&(!char.IsWhiteSpace(s[ptr]))){
            count+=1;
            ptr-=1;
        }
        return count;
    }
}