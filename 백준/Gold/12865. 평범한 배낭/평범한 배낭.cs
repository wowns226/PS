namespace BOJ
{
    class No_12865
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(arr[0]), weight = int.Parse(arr[1]);
            int[,] dp = new int[n+1, weight+1];
          
            for (int i = 1; i <= n; i++)
            {
                arr = Console.ReadLine().Split();
                int  w = int.Parse(arr[0]);
                int  value = int.Parse(arr[1]);
                for (int j = 1; j <= weight; j++)
                {
                    if(w<=j)
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - w] + value);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }

                }
            }
            Console.Write(dp[n,weight]);
        }
    }
}