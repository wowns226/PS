namespace BOJ
{
    class No_1965
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int[] dp = new int[n];                

            int myMax = int.MinValue;
            for(int i=0 ;i<n ;i++)
            {
                dp[i] = 1;
                for(int j=0 ;j<i ;j++)
                {
                    if(inputs[i] <= inputs[j]) continue;
                    else dp[i] = Math.Max(dp[i], dp[j] + 1);
                }

                myMax = Math.Max(dp[i], myMax);
            }

            output.Write(myMax);
        }
    }
}
