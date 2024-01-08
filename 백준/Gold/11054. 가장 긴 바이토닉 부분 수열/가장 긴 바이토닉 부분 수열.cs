namespace BOJ
{
    class No_11054
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] dp = new int[n, 2];
            
            for (int i = 0; i < n; i++)
            {
                dp[i, 0] = 1;
                for (int j = 0; j <= i; j++)
                {
                    if (inputs[i] > inputs[j] && dp[i, 0] < dp[j, 0] + 1)
                    {
                        dp[i, 0] = dp[j, 0] + 1;
                    }
                }
            }
            
            for (int i = n-1; i >= 0; i--)
            {
                dp[i, 1] = 1;
                for (int j = n-1; j >= i; j--)
                {
                    if (inputs[i] > inputs[j] && dp[i, 1] < dp[j, 1] + 1)
                    {
                        dp[i, 1] = dp[j, 1] + 1;
                    }
                }
            }
            
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                int temp = dp[i, 0] + dp[i, 1] - 1;
                if (answer < temp)
                {
                    answer = temp;
                }
            }

            Console.WriteLine(answer);
        }
    }
}