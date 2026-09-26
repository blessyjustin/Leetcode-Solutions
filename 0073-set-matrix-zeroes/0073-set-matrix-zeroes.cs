public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m=matrix.Length;
        int n=matrix[0].Length;
        HashSet<int> row=new HashSet<int>();
        HashSet<int> col=new HashSet<int>();
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(matrix[i][j]==0)
                {
                    row.Add(i);
                    col.Add(j);
                }
            }
        }
        foreach(int r in row)
        {
            for(int i=0;i<n;i++)
            {
                matrix[r][i]=0;
            }
        }
        foreach(int c in col)
        {
            for(int i=0;i<m;i++)
            {
                matrix[i][c]=0;
            }
        }

    }
}