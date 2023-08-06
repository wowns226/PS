namespace BOJ
{
    class No_11057
    {
        const int MOD = 10_007;

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());

            // 오르막 수 : 수의 자리가 오름차순 or 같은 수

            int[,] dp = new int[n + 1, 10];

            for(int i = 0 ; i < 10 ; i++)
                dp[1, i] = 1;

            for(int i = 1 ; i <= n ; i++)
                for(int j = 0 ; j < 10 ; j++)
                    for(int k=0 ;k<=j ;k++)
                        dp[i, j] = (dp[i, j] + dp[i - 1, k]) % MOD;
                    
            long answer = 0;
            for(int i = 0 ; i < 10 ; i++)
                answer += dp[n, i];

            output.WriteLine(answer % MOD);
        }
    }
}

