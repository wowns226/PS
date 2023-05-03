namespace BOJ
{
    class No_11052
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(input.ReadLine());

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int[] arr = new int[N + 1];
            int[] dp = new int[N + 1];

            arr[0] = dp[0] = 0;
            for(int i = 1 ; i <= N ; i++)
                arr[i] = inputs[i - 1];

            for(int i=1 ;i<=N ;i++)
                for(int j=1 ;j<=i ;j++)
                    dp[i] = Math.Max(dp[i], dp[i - j] + arr[j]);
                
            

            output.Write(dp[N]);
        }
    }
}