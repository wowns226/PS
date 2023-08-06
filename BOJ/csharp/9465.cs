namespace BOJ
{
    class No_9465
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = int.Parse(input.ReadLine());

            while(t-- > 0)
            {
                int n = int.Parse(input.ReadLine());

                int[][] array = new int[2][];
                array[0] = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                array[1] = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

                int[,] dp = new int[2, n];

                dp[0, 0] = array[0][0];
                dp[1, 0] = array[1][0];

                for(int i=1 ;i<n ;i++)
                {
                    if(i==1)
                    {
                        dp[0, 1] = dp[1, 0] + array[0][1];
                        dp[1, 1] = dp[0, 0] + array[1][1];
                    }
                    else
                    {
                        dp[0, i] = Math.Max(dp[1, i - 1] + array[0][i], dp[1, i - 2] + array[0][i]);
                        dp[1, i] = Math.Max(dp[0, i - 1] + array[1][i], dp[0, i - 2] + array[1][i]);
                    }
                }

                output.WriteLine(Math.Max(dp[0, n-1], dp[1, n-1]));
            }
        }
    }
}

