namespace BOJ_1446
{
    class Program
    {
        // dp?
        // 다익스트라?
        
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int n = inputs[0];
            int d = inputs[1];

            int answer = 0;

            Dictionary<int, List<(int, int)>> dict = new Dictionary<int, List<(int, int)>>(); // Key : 출발지점 Value : 도착지점, 지름길 거리
            
            for (int i = 0; i < n; i++)
            {
                inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                
                // 그냥 거리가 더 짧은 경우
                if (inputs[1] - inputs[0] <= inputs[2]) continue;
                // 목적지보다 더 멀리 가는 경우 (역주행할 수 없다)
                if (inputs[1] > d) continue;
                
                dict.TryAdd(inputs[0], new List<(int, int)>());

                dict[inputs[0]].Add((inputs[1], inputs[2]));
            }

            // dp[i] i키로까지 주행시 이동할 수 있는 최소 주행 거리
            int[] dp = new int[d + 1];

            // 지름길을 가지 않고 갈 수 있는 방식으로 초기화
            for (int i = 0; i <= d; i++)
            {
                dp[i] = i;
            }
            
            for (int i = 0; i <= d; i++)
            {
                // 
                int beforeDist = i == 0 ? -1 : dp[i - 1];
                
                dp[i] = Math.Min(dp[i], (beforeDist + 1));

                if (dict.ContainsKey(i) == false) continue;
                
                for (int j = 0; j < dict[i].Count; j++)
                {
                    if (dp[dict[i][j].Item1] > dp[i] + dict[i][j].Item2)
                    {
                        dp[dict[i][j].Item1] = dp[i] + dict[i][j].Item2;
                    }
                }
            }
            
            sw.Write(dp[d]);
            
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}

