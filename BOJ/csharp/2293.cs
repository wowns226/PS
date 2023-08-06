namespace BOJ
{
    class No_2293
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(),int.Parse);
            int n = inputs[0];
            int k = inputs[1];

            int[] coins = new int[n+1];

            for(int i=1 ;i<=n ; i++)
                coins[i] = int.Parse(input.ReadLine());

            // 코인들을 이용해서 k 만들기
            // dp[i, j] = i번째 코인까지 사용하여 k를 만들 수 있는 경우의 수

            int[,] dp = new int[n + 1, k + 1];

            for (int i=1 ;i<=n ; i++)
            {
                dp[i, 0] = 1;
            }

            for(int i=1 ;i<=n ;i++)
            {
                for(int j=1 ;j<=k ;j++)
                {
                    if(j >= coins[i])
                        dp[i, j] = dp[i - 1, j] + dp[i, j - coins[i]];
                    else
                        dp[i, j] = dp[i - 1, j];
                }
            }

            output.Write(dp[n, k]);
        }
    }
}

