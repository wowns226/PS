namespace BOJ
{
    class No_7579
    {
        static void Main()
        {
            int N, M, sum = 0;

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            N = inputs[0];
            M = inputs[1];

            int[] bite = new int[N + 1];
            int[] cost = new int[N + 1];
            int[,] dp = new int[N + 1, 10001];
            
            inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 1; i <= N; i++)
                bite[i] = inputs[i - 1];

            inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 1; i <= N; i++)
            {
                cost[i] = inputs[i - 1];
                sum += cost[i];
            }

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j <= sum; j++)
                {
                    if (j - cost[i] >= 0)
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - cost[i]] + bite[i]);

                    dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j]);
                }
            }

            for (int i = 0; i <= sum; i++)
            {
                if (dp[N, i] < M) continue;
                
                Console.WriteLine(i);
                break;
            }
        }
    }
}