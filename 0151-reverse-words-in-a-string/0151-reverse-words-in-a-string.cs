public class Solution {
    public string ReverseWords(string s) {
        s=s.Trim();
        string[]  st=s.Split(' ');
        string ans="";
        for(int i=st.Length-1;i>0;i--){
            if(st[i].Length>0){
            ans+=st[i]+" ";}
        }
        return ans+st[0];
    }
}