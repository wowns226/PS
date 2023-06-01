namespace BOJ
{
    class No_10870
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] pibo = new int[21];

            pibo[0] = 0;
            pibo[1] = 1;

            for(int i=2 ;i<pibo.Length ;i++)
            {
                pibo[i] = pibo[i - 2] + pibo[i - 1];
            }

            int n = int.Parse(input.ReadLine());

            output.Write(pibo[n]);
        }
    }
}
