namespace BOJ
{
    class No_2133
    {
        

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());

            int[] dp = new int[31];

            dp[0] = 1;
            dp[2] = 3;

            if (n > 2)
            {
                for(int i = 4 ; i <= n ; i++)
                {
                    dp[i] = dp[i - 2] * 3;

                    for(int j = i - 4 ; j >= 0 ; j -= 2)
                    {
                        dp[i] += dp[j] * 2;
                    }
                }
            }

            output.WriteLine(dp[n]);
        }
    }
}

