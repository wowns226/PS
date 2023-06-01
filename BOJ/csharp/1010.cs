namespace BOJ
{
    class No_1010
    {
        static int[,] dp = new int[31, 31];

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            Combination();

            int t = int.Parse(input.ReadLine());

            while(t-->0)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int n = inputs[0];
                int m = inputs[1];

                output.WriteLine(dp[m, n]);
            }
        }

        static void Combination()
        {
            for(int i=0 ;i<31 ;i++)
            {
                dp[i, 0] = 1;
                dp[i, i] = 1;
                for(int j=1 ;j<i ;j++)
                {
                    dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                }
            }
        }
    }
}