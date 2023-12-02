using System.Text;

namespace BOJ_9017
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            StringBuilder sb = new StringBuilder();
            int t = int.Parse(sr.ReadLine());
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            List<(int,int)> list = new List<(int,int)>();

            while (t-- > 0)
            {
                dict.Clear();
                list.Clear();
                
                int n = int.Parse(sr.ReadLine());
                
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                for (int i = 0; i < n; i++)
                {
                    dict.TryAdd(inputs[i], new List<int>());
                    dict[inputs[i]].Add(i + 1);
                }
                
                int rank = 1;
                for (int i = 0; i < n; i++)
                {
                    if (dict[inputs[i]].Count < 6) continue;
                    
                    list.Add((inputs[i], rank));
                    rank++;
                }
                
                dict.Clear();

                for (int i = 0; i < list.Count; i++)
                {
                    dict.TryAdd(list[i].Item1, new List<int>());
                    dict[list[i].Item1].Add(list[i].Item2);
                }

                int sumScore = int.MaxValue;
                int score = int.MaxValue;
                int answer = 0;
                foreach (var item in dict)
                {
                    int sum = item.Value.Take(4).Sum();

                    if (sum == sumScore)
                    {
                        sumScore = sum;

                        if (item.Value[4] < score)
                        {
                            score = item.Value[4];
                            answer = item.Key;
                        }
                    }
                    else if (sum < sumScore)
                    {
                        sumScore = sum;
                        score = item.Value[4];
                        answer = item.Key;
                    }
                }

                sb.AppendLine(answer.ToString());
            }
            
            sw.Write(sb);
        }
    }
}
