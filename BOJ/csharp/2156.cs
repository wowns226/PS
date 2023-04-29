namespace BOJ
{
    class No_2156
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            const int MY_MAX = 10_005;

            int n = int.Parse(input.ReadLine());

            int[] arr = new int[MY_MAX];
            int[] dp = new int[MY_MAX];

            for(int i = 1 ; i <= n ; i++)
                arr[i] = int.Parse(input.ReadLine());

            dp[1] = arr[1];
            dp[2] = dp[1] + arr[2];
            for(int i=3 ;i< MY_MAX ;i++)
            {
                dp[i] = Math.Max(dp[i - 3] + arr[i - 1] + arr[i], dp[i - 2] + arr[i]);
                dp[i] = Math.Max(dp[i - 1], dp[i]);
            }

            output.Write(dp[n]);
        }
    }
}