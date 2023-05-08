namespace BOJ
{
    class No_4095
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int n = inputs[0];
                int m = inputs[1];

                if(n == 0 && m == 0) break;

                int[,] board = new int[n, m];
                for(int i = 0 ; i < n ; i++)
                {
                    inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                    for(int j = 0 ; j < m ; j++)
                    {
                        board[i, j] = inputs[j];
                    }
                }

                int answer = 0;
                for(int i=0 ;i<n ;i++)
                {
                    for(int j=0 ;j<m ;j++)
                    {
                        if(i == 0 || j == 0)
                        {
                            answer = Math.Max(answer, board[i, j]);
                        }
                        else
                        {
                            if(board[i, j] == 0) continue;

                            board[i, j] = Min(board[i, j - 1], board[i - 1, j], board[i - 1, j - 1]) + 1;

                            answer = Math.Max(answer, board[i, j]);
                        }
                    }
                }

                output.WriteLine(answer);
            }
            
        }

        static int Min(int a, int b, int c) => Math.Min(Math.Min(a, b), c);
    }
}