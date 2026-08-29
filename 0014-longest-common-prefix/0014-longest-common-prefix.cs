public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string p=strs[0];
        for(int i=0;i<strs.Length;i++)
        {
            while(!strs[i].StartsWith(p))
            {
                p=p.Substring(0,p.Length-1);
                if(p.Length==0)
                {
                    return "";
                }
            }
        }
        return p;
    }
}