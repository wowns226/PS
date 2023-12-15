namespace BOJ_5568
{
    class Program
    {
        static int n, k;
        static List<int> cards = new List<int>();
        static bool[] used;
        static HashSet<string> hashSet = new HashSet<string>();

        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            n = int.Parse(sr.ReadLine());
            k = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                cards.Add(int.Parse(sr.ReadLine()));
            }

            used = new bool[n];

            DFS(0, "");

            sw.Write(hashSet.Count);

            sr.Close();
            sw.Flush();
            sw.Close();
        }

        static void DFS(int idx, string str)
        {
            if (idx == k)
            {
                hashSet.Add(str);

                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (used[i] == false)
                {
                    used[i] = true;
                    DFS(idx + 1, str + cards[i]);
                    used[i] = false;
                }
            }
        }
    }
}

