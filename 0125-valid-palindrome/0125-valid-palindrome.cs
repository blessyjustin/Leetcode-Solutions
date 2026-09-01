public class Solution {
    public bool IsPalindrome(string s) {
        s=s.ToLower();
        string st="";
        foreach(char ch in s)
        {
            if(char.IsLetterOrDigit(ch))
            {
                st+=ch;
            }
        }
        int left=0;
        int right=st.Length-1;
        while(left<right)
        {
            if(st[left]!=st[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}