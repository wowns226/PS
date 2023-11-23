using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_17069
    {
        static void Main(string[] args)
        {
            long[,,] dp = new long[35,35,35];
            int[,] board = new int[35, 35];
            int n = int.Parse(Console.ReadLine());

            dp[0, 1, 2] = 1;
            for (int i = 1; i <= n; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 1; j <= n; j++)
                    board[i, j] = int.Parse(inputarr[j - 1]);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (board[i, j + 1] == 0)
                        dp[0, i, j + 1] += dp[0, i, j] + dp[2, i, j];
                    if (board[i + 1, j] == 0)
                        dp[1, i + 1, j] += dp[1, i, j] + dp[2, i, j];
                    if (board[i, j + 1] == 0 && board[i + 1, j] == 0 && board[i + 1, j + 1] == 0)
                        dp[2, i + 1, j + 1] += dp[0, i, j] + dp[1, i, j] + dp[2, i, j];
                }
            }

            Console.WriteLine(dp[0,n,n] + dp[1,n,n] + dp[2,n,n]);
        }
    }
    
}