namespace BOJ
{
    class No_10844
    {
        const int MOD = 1_000_000_000;

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());

            long[,] dp = new long[n + 1, 10];

            for(int i = 1 ; i < 10 ; i++)
                dp[1, i] = 1;

            for(int i = 2 ; i <= n ; i++)
            {
                for(int j = 0 ; j < 10 ; j++)
                {
                    if(j == 0)
                        dp[i, j] = dp[i - 1, j + 1] % MOD;
                    else if(j == 9)
                        dp[i, j] = dp[i - 1, j - 1] % MOD;
                    else
                        dp[i, j] = (dp[i - 1, j - 1] + dp[i - 1, j + 1]) % MOD;
                }
            }

            long answer = 0;
            for(int i = 0 ; i < 10 ; i++)
                answer += dp[n, i];

            output.WriteLine(answer % MOD);
        }
    }
}