namespace BOJ_24390
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = sr.ReadLine().Split(':').Select(int.Parse).ToArray();
            int M = inputs[0];
            int S = inputs[1];

            int cookingTime = (int)((M * 60 + S) * 0.1);

            int[] times = { 1, 3, 6, 60 };
            
            // dp[i]는 i * 10초일때 최소 버튼 누른 횟수
            // i의 범위는 1 ~ 360

            int[] dp = new int[361];
            dp[0] = 1;
            dp[1] = 2;
            dp[2] = 3;
            
            dp[3] = 1;
            dp[4] = 2;
            dp[5] = 3;
            
            dp[6] = 2;
            
            dp[60] = 2;

            for (int i = 0; i < 361; i++)
            {
                if (dp[i] != 0) continue;

                if (6 < i && i < 60)
                {
                    dp[i] = i/6 + dp[i % 6];
                }
                else if(i >= 60)
                {
                    dp[i] = i/60 + dp[i % 60];
                }
            }
            sw.WriteLine(dp[cookingTime]);
        }
    }
}

