using System.Text;

namespace BOJ_2535
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            StringBuilder sb = new StringBuilder();
            List<(int, int, int)> list = new List<(int, int, int)>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                list.Add((inputs[0], inputs[1], inputs[2]));
            }

            var sorted = list.OrderByDescending(x => x.Item3).ToList();

            int rank = 1;
            
            for (int i = 0; i < sorted.Count(); i++)
            {
                if (rank == 4) break;
                
                dict.TryAdd(sorted[i].Item1, 0);

                if (dict[sorted[i].Item1] == 2) continue;
                
                dict[sorted[i].Item1]++;
                
                sb.AppendLine($"{sorted[i].Item1} {sorted[i].Item2}");
                rank++;
            
            }

            sw.Write(sb);
        }
    }
}
