public class Solution {
    public void GameOfLife(int[][] board) {
        int m=board.Length;
        int n=board[0].Length;

        int [][]next=new int[m][];
        for(int i=0;i<m;i++)
        {
            next[i]=new int[n];
        }

        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                int live=0;
                for(int r=-1;r<=1;r++)
                {
                    for(int c=-1;c<=1;c++)
                    {
                        if(r==0 && c==0)
                            continue;

                        int nr=i+r;
                        int nc=j+c;

                        if(nr>=0&&nr<m&&nc>=0&&nc<n)
                        {
                            if(board[nr][nc]==1)
                            {
                                live++;
                            }
                        }
                    }
                }
                if(board[i][j]==1)
                {
                    if(live==2||live==3)
                    {
                        next[i][j]=1;
                    }
                    else{
                        next[i][j]=0;
                    }
                }
                else
                {
                    if(live==3)
                    {
                        next[i][j]=1;
                    }
                    else{
                        next[i][j]=0;
                    }

                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                board[i][j] = next[i][j];
            }
        }
    }
}