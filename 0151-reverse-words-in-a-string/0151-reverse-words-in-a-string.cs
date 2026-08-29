public class Solution {
    public string ReverseWords(string s) {
        string[]  st=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        string ans="";
        for(int i=st.Length-1;i>=0;i--){
            ans+=st[i]+" ";
        }
        return ans.Trim();
    }
}