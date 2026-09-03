public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left=0;
        HashSet <char> set=new HashSet<char>();
        int maxlength=0;
        for(int right=0;right<s.Length;right++)
        {
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;            
            }
            set.Add(s[right]);
            maxlength=Math.Max(maxlength,right-left+1);
        }
        return maxlength;
    }
}