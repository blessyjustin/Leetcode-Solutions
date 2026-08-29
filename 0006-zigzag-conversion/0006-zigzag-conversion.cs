public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows==1 || s.Length<=numRows)
        {
            return s;
        }
        string[] rows= new string[numRows];
        int row=0;
        int dir=1;
        foreach(char c in s)
        {
            rows[row]+=c;
            if(row==0)
            {
                dir=1;
            }
            else if(row==numRows-1)
            {
                dir=-1;
            }
            row+=dir;
        }
        return string.Join("",rows);
    }
}