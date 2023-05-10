namespace BOJ
{
    class No_28017
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(),int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            const int MY_MAX = 505;

            int[,] arr = new int[n+1, m+1];
            int[,] dp = new int[n + 1, m + 1];

            for(int i=1 ;i<=n ;i++)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                for(int j=1 ;j<=m ;j++)
                {
                    arr[i, j] = inputs[j - 1];
                }
            }

            for(int i = 1 ; i <= m ; i++)
                dp[1, i] = arr[1, i];

            for(int i=2 ;i<=n ;i++)
            {
                for(int j=1 ;j<=m ;j++)
                {
                    int myMin = int.MaxValue;
                    for(int k=1 ;k<=m ;k++)
                    {
                        if(j == k) continue;

                        myMin = Math.Min(dp[i - 1, k], myMin);
                    }

                    dp[i, j] = myMin + arr[i, j];
                }
            }

            int answer = int.MaxValue;
            for(int i=1 ;i<=m ;i++)
                answer = Math.Min(answer, dp[n, i]);

            output.WriteLine(answer);
        }
    }
}