using System.Text;

namespace BOJ_1485
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            StringBuilder sb = new StringBuilder();
            int t = int.Parse(sr.ReadLine());

            while (t-- > 0)
            {
                (int, int) a = (0, 0), b = (0, 0), c = (0, 0), d = (0, 0);
                for (int i = 0; i < 4; i++)
                {
                    int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                    switch (i)
                    {
                        case 0:
                            a = (inputs[0], inputs[1]);
                            break;
                        case 1:
                            b = (inputs[0], inputs[1]);
                            break;
                        case 2:
                            c = (inputs[0], inputs[1]);
                            break;
                        case 3:
                            d = (inputs[0], inputs[1]);
                            break;
                    }
                }

                if (IsSquare(a, b, c, d))
                {
                    sb.AppendLine("1");
                }
                else
                {
                    sb.AppendLine("0");
                }
            }

            sw.Write(sb);
        }

        static bool IsSquare((int, int) a, (int, int) b, (int, int) c, (int, int) d)
        {
            List<long> list = new List<long>();
            // a와 b의 거리
            long dx1 = a.Item1 - b.Item1;
            long dy1 = a.Item2 - b.Item2;
            // b와 c의 거리
            long dx2 = b.Item1 - c.Item1;
            long dy2 = b.Item2 - c.Item2;
            // c와 d의 거리
            long dx3 = c.Item1 - d.Item1;
            long dy3 = c.Item2 - d.Item2;
            // d와 a의 거리
            long dx4 = d.Item1 - a.Item1;
            long dy4 = d.Item2 - a.Item2;
            // a와 c의 거리
            long dx5 = a.Item1 - c.Item1;
            long dy5 = a.Item2 - c.Item2;
            // b와 d의 거리
            long dx6 = b.Item1 - d.Item1;
            long dy6 = b.Item2 - d.Item2;

            list.Add(dx1 * dx1 + dy1 * dy1);
            list.Add(dx2 * dx2 + dy2 * dy2);
            list.Add(dx3 * dx3 + dy3 * dy3);
            list.Add(dx4 * dx4 + dy4 * dy4);
            list.Add(dx5 * dx5 + dy5 * dy5);
            list.Add(dx6 * dx6 + dy6 * dy6);

            list.Sort();

            return list[0] == list[1] && list[1] == list[2] && list[2] == list[3] && list[3] == list[0] && list[4] == list[5];
        }
    }
}
