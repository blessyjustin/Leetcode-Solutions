public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==1){
            return strs[0];
        }
        Array.Sort(strs);
        string f= strs[0];
        string l= strs[strs.Length-1];
        string pre="";
        for(int i=0;i<=Math.Min(f.Length,l.Length)-1;i++){
            if(f[i]!=l[i]){
                return pre;
            }
            pre+=f[i];
        }
        return pre;
    }
}