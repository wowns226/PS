namespace BOJ
{
    class No_1912
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] arr = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int[] dp = new int[arr.Length];

            dp[0] = arr[0];
            int answer = arr[0];

            for (int i=1 ;i<dp.Length ;i++)
            {
                dp[i] = Math.Max(dp[i - 1] + arr[i], arr[i]);
                answer = Math.Max(answer, dp[i]);
            }

            output.WriteLine(answer);
        }
    }
}