namespace BOJ_14425
{
    class Program
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            HashSet<string> hashSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                hashSet.Add(Console.ReadLine());
            }

            int answer = 0;
            for (int i = 0; i < m; i++)
            {
                if (hashSet.Contains(Console.ReadLine()))
                {
                    answer++;
                }
            }
            
            Console.Write(answer);
        }
    }
}

