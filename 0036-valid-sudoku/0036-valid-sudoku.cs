public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen=new HashSet<string>();
        for(int i=0;i<9;i++)
        {
            for(int j=0;j<9;j++)
            {
                char n=board[i][j];
                if(n=='.')
                {
                    continue;
                }
                string row=$"r{n}{i}";
                string col=$"c{n}{j}";
                int boxindex=(i/3)*3+(j/3);
                string box=$"b{n}{boxindex}";

                if(seen.Contains(row)|| seen.Contains(col)||seen.Contains(box))
                {
                    return false;
                }
                seen.Add(row);
                seen.Add(col);
                seen.Add(box);
            }
        }
        return true;
    }
}