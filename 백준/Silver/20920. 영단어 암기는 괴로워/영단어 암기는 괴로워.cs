using System.Text;

namespace BOJ_20920
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            StringBuilder sb = new StringBuilder();

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
 
                if (s.Length < m) continue;

                dict.TryAdd(s, 0);

                dict[s]++;
            }

            var sorted = dict.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key.Length).ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var item in sorted)
            {
                sb.AppendLine(item.Key);
            }

            Console.Write(sb);
        }
    }
}
