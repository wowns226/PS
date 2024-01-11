namespace BOJ
{
    class No_9251
    {
        static void Main()
        {
            string s1 = Input(); 
            string s2 = Input();

            int answer = GetLCS(s1, s2);
            
            Console.WriteLine(answer);
        }

        static int GetLCS(string s1, string s2)
        {
            int s1Len = s1.Length;
            int s2Len = s2.Length;

            // dp[i, j] => s1을 i까지 s2를 j까지 사용했을 때의 최소공통부분조합
            int[,] dp = new int[s1Len + 1, s2Len + 1];
            
            // dp 세팅
            // 둘 중 한개라도 0개의 길이를 사용한다면 무조건 0
            dp[0, 0] = 0;
            dp[0, 1] = 0;
            dp[1, 0] = 0;

            for (int i = 1; i <= s1Len; i++)
            {
                for (int j = 1; j <= s2Len; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[s1Len, s2Len];
        }

        static string Input() => Console.ReadLine();
    }
}