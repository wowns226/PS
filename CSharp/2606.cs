using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/2606

namespace BOJ
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int n;
        static int m;
        static int cptNum = 0;
        static bool[,] connected = new bool[101, 101];
        static bool[] visited = new bool[101];

        static void CheckBirusComputer(int _idx)
        {
            visited[_idx] = true;
            for (int i = 1; i <= n; i++)
            {
                if (connected[_idx, i] && !visited[i])
                {
                    cptNum++;
                    CheckBirusComputer(i);
                }
            }
        }

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                connected[x, y] = true;
                connected[y, x] = true;
            }

            CheckBirusComputer(1);

            sb.Append(cptNum);

            Console.WriteLine(sb.ToString());
        }
    }
}