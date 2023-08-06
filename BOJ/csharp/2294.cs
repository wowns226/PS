namespace BOJ
{
    class No_2294
    {
        const int MY_MAX = 10_000_000;

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(),int.Parse);
            int n = inputs[0];
            int k = inputs[1];

            int[] coins = new int[n+1];

            for(int i=0 ;i<n ; i++)
                coins[i] = int.Parse(input.ReadLine());

            int[] dp = new int[k+1];

            for(int i = 1 ; i <= k ; i++)
                dp[i] = MY_MAX;

            for(int i=0 ;i<n ;i++)
            {
                for(int j=1 ;j<=k ;j++)
                {
                    if(j >= coins[i])
                        dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
                }
            }

            dp[k] = dp[k] == MY_MAX ? -1 : dp[k];

            output.Write(dp[k]);
        }
    }
}

