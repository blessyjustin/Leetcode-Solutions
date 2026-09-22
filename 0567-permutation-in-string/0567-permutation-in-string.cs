public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        int window_size=s1.Length;
        int []freq=new int[26];
        int left=0;

        foreach(char ch in s1)
        {
            freq[ch-'a']++;
        }

        for(int right=0;right<s2.Length;right++)
        {
            freq[s2[right]-'a']--;
            if((right-left+1)>window_size)
            {
                freq[s2[left]-'a']++;;
                left++;
            }
            if((right-left+1)==window_size && isZero(freq))
            {
                return true;
            }
        }
        return false;
    }
 static bool isZero(int [] freq){
    foreach(int c in freq)
    {
        if(c!=0){
            return false;
        }
    }
    return true;
}
}