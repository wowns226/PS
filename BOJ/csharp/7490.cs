namespace BOJ
{
    class No_7490
    {
        static int N;

        static void Main()
        {
            //using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = int.Parse(Console.ReadLine());

            while(t-- > 0)
            {
                N = int.Parse(Console.ReadLine());

                DFS(0, 1, 1, 1, "1");

                Console.WriteLine();
            }
        }

        static void DFS(int sum, int sign, int num, int n, string str)
        {
            if(n == N)
            {
                sum += (num * sign);
                if(sum==0)
                {
                    Console.WriteLine(str);
                }
            }
            else
            {
                DFS(sum, sign, num * 10 + (n + 1), n + 1, str + ' ' + (char)(n + 1 + '0'));
                DFS(sum + (sign * num), 1, n + 1, n + 1, str + '+' + (char)(n + 1 + '0'));
                DFS(sum + (sign * num), -1, n + 1, n + 1, str + '-' + (char)(n + 1 + '0'));
            }
        }
    }
}

