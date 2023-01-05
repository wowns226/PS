using System;
using System.Collections.Generic;
using System.Text;

namespace BOJ
{
    internal class MainApp
    {
        static long[] dp = new long[36];

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            dp[0] = 1;
            for (int i = 1; i < 36; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            Console.WriteLine(dp[n]);
        }
    }
}