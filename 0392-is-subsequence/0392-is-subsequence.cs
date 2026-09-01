public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        int sptr=0;
        int tptr=0;
        while(sptr<s.Length)
        {
            if(tptr<=t.Length-1)
            {
                if(t[tptr]!=s[sptr])
                {
                    tptr++;
                }
                else
                {
                    sptr++;
                    tptr++;
                }
            }
            else
            {
                return false;
            } 
            
        }
        return true;
    }
}