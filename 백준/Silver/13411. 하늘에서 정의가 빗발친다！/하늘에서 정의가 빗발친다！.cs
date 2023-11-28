using System.Text;

namespace BOJ_13411
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            List<(int, double)> list = new List<(int, double)>(); // index, sec
            for (int i = 0; i < n; i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                double length = Math.Sqrt(inputs[0] * inputs[0] + inputs[1] * inputs[1]);
                list.Add((i + 1, length / inputs[2]));
            }

            var sorted = list.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();

            foreach (var item in sorted)
            {
                sb.AppendLine($"{item.Item1}");
            }

            Console.Write(sb);
        }
    }
}
