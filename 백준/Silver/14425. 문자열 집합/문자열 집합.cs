namespace BOJ_14425
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                dict.TryAdd(sr.ReadLine(), true);
            }

            int answer = 0;
            for (int i = 0; i < m; i++)
            {
                if (dict.ContainsKey(sr.ReadLine()))
                {
                    answer++;
                }
            }
            
            sw.Write(answer);
            
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}

