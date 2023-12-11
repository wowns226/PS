using System.Text;

namespace BOJ_1198
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            List<(int, int)> list = new List<(int, int)>();
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                list.Add((inputs[0], inputs[1]));
            }

            double answer = 0;
            for (int a = 0; a < n; a++)
            {
                for (int b = a + 1; b < n; b++)
                {
                    for (int c = b + 1; c < n; c++)
                    {
                        // a와 b의 거리
                        double ab = Math.Sqrt(Math.Pow((list[a].Item1 - list[b].Item1), 2) + Math.Pow((list[a].Item2 - list[b].Item2),2));
                        // b와 c의 거리
                        double ba = Math.Sqrt(Math.Pow((list[b].Item1 - list[c].Item1), 2) + Math.Pow((list[b].Item2 - list[c].Item2),2));
                        // c와 a의 거리
                        double ca = Math.Sqrt(Math.Pow((list[c].Item1 - list[a].Item1), 2) + Math.Pow((list[c].Item2 - list[a].Item2),2));

                        double s = (ab + ba + ca) * 0.5;
                        double temp = Math.Sqrt(s * (s - ab) * (s - ba) * (s - ca));

                        answer = Math.Max(answer, temp);
                    }
                }
            }

            sw.Write(answer);
        }
    }
}
