namespace cs
{
    class No_5567
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int m = int.Parse(input.ReadLine());

            int cnt = 0;
            int[,] board = new int[501, 501];
            int[] f = new int[501];

            while(m-->0)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int a = inputs[0];
                int b = inputs[1];

                board[a, b] = 1;
                board[b, a] = 1;

                if(a == 1) f[b] = 1;
                else if(b == 1) f[a] = 1;
            }

            for(int i=2 ;i<=n ;i++)
            {
                if(board[1, i] == 1)
                {
                    for(int j=2 ;j<=n ; j++)
                    {
                        if(board[i, j] == 1)
                        {
                            f[j] = 1;
                        }
                    }
                }
            }

            for(int i=2 ;i<=n ; i++)
            {
                if(f[i] == 1)
                {
                    cnt++;
                }
            }

            output.Write(cnt);
        }
    }
}