public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length<t.Length){
            return "";
        }
        Dictionary<char,int> need=new Dictionary<char,int>();
        foreach(char ch in t){
            if(need.ContainsKey(ch))
            {
                need[ch]++;
            }
            else
            {
                need[ch]=1;
            }
        }
        int left=0;
        int minLen=int.MaxValue;
        int required=t.Length;
        int start=0;
        for(int right=0;right<s.Length;right++)
        {
            if(need.ContainsKey(s[right])){
                if(need[s[right]]>0){
                    required--;
                }
                need[s[right]]--;
            }
            while(required==0)
            {
                if(right-left+1<minLen){
                    minLen=right-left+1;
                    start=left;
                }
                if(need.ContainsKey(s[left])){
                    need[s[left]]++;
                    if(need[s[left]]>0){
                        required++;
                    }
                }
                left++;
            }
        }
        return minLen==int.MaxValue?"":s.Substring(start,minLen);
    }
}