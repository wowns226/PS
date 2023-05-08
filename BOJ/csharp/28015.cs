namespace BOJ
{
    class No_28015
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            int[,] board = new int[n, m];

            for(int i=0 ;i<n ;i++)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<m ;j++)
                {
                    board[i, j] = inputs[j];
                }
            }

            
            long count = 0;
            for(int i=0 ;i<n ;i++)
            {
                bool one = false;
                bool two = false;
                int area1 = 0;
                int area2 = 0;
                for(int j=0 ;j<m ;j++)
                {
                    if(!one && board[i,j] == 1)
                    {
                        area1++;
                        one = true;
                        two = false;
                    }
                    else if(!two && board[i, j]==2)
                    {
                        area2++;
                        one = false;
                        two = true;
                    }

                    if(board[i, j] == 0 || j == m - 1)
                    {
                        if(area1 == 0 && area2 == 0)
                            continue;

                        count += Math.Min(area1, area2) + 1;
                        area1 = 0;
                        area2 = 0;
                        one = false;
                        two = false;
                    }
                }
            }

            output.Write(count);
        }
    }
}