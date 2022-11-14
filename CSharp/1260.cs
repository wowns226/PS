using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1260

namespace BOJ
{
    internal class Program
    {
        static void DFS(int _n, int[,] _arr, bool[] _visited, int _start, StringBuilder _sb)
        {
            _sb.Append(_start.ToString() + ' ');
            _visited[_start] = true;

            for (int i = 0; i < _n + 1; i++)
            {
                if (_arr[_start, i] == 0) continue;
                if (_visited[i]) continue;

                DFS(_n, _arr, _visited, i, _sb);
            }
        }

        static void BFS(int _n, int[,] _arr, bool[] _visited, int _start, StringBuilder _sb)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(_start);
            _visited[_start] = true;

            while (q.Count != 0)
            {
                int cur = q.First();
                q.Dequeue();
                _sb.Append(cur.ToString() + ' ');

                for (int i = 0; i < _n + 1; i++)
                {
                    if (_arr[cur, i] == 0) continue;
                    if (_visited[i]) continue;

                    q.Enqueue(i);
                    _visited[i] = true;
                }
            }
        }

        static void Main()
        {
            StringBuilder sbDFS = new StringBuilder();
            StringBuilder sbBFS = new StringBuilder();

            int[,] arr = new int[1001, 1001];
            bool[] visitedDFS = new bool[1001];
            bool[] visitedBFS = new bool[1001];

            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int start = int.Parse(input[2]);

            for (int i = 0; i < m; i++)
            {
                string[] inputAB = Console.ReadLine().Split(' ');
                int a = int.Parse(inputAB[0]);
                int b = int.Parse(inputAB[1]);

                arr[a, b] = 1;
                arr[b, a] = 1;
            }

            DFS(n, arr, visitedDFS, start, sbDFS);
            Console.WriteLine(sbDFS.ToString());



            BFS(n, arr, visitedBFS, start, sbBFS);
            Console.WriteLine(sbBFS.ToString());
        }
    }
}