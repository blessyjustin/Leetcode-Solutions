public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int window_size=s1.Length;
        int []s1freq=new int[26];
        int []windowfreq=new int[26];
        int left=0;

        foreach(char ch in s1)
        {
            s1freq[ch-'a']++;
        }

        for(int right=0;right<s2.Length;right++)
        {
            windowfreq[s2[right]-'a']++;
            if((right-left+1)>window_size)
            {
                windowfreq[s2[left]-'a']--;
                left++;
            }
            if((right-left+1)==window_size && s1freq.SequenceEqual(windowfreq))
            {
                return true;
            }
        }
        return false;
    }
}