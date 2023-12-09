namespace BOJ_17626
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine());
            
            // dp[i] : i라는 숫자를 표현하는 최소 개수의 제곱수의 합
            int[] dp = new int[50001];

            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] + 1;

                for (int j = 1; j*j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }
            
            sw.Write(dp[n]);
        }
    }
}
