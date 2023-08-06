namespace BOJ
{
    class No_11048
    {

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int n = inputs[0];
            int m = inputs[1];

            int[,] dp = new int[n+1, m+1];

            for(int i=1 ;i<=n ;i++)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

                for(int j=1 ;j<=m ;j++)
                    dp[i, j] = inputs[j-1];
            }

            for(int i=1 ;i<=n ;i++)
                for(int j=1 ;j<=m ; j++)
                    dp[i, j] += Math.Max(Math.Max(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]);

            output.WriteLine(dp[n, m]);
        }
    }
}