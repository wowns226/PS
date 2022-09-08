using System;
using System.Collections.Generic;

/***************************************************************************************
 *   * 링크 : https://www.acmicpc.net/problem/1260
 ***************************************************************************************/

namespace BaekJoon
{
    class Graph
    {
        int[,] arr = new int[1001, 1001];

        bool[] dfsvisited = new bool[1001];
        bool[] bfsvisited = new bool[1001];

        public void SetArrIndex(int _row, int _cal)
        {
            arr[_row, _cal] = 1;
            arr[_cal, _row] = 1;
        }

        public void DFS(int _N, int _start)
        {
            Console.Write("{0} ", _start);

            dfsvisited[_start] = true;

            for (int i = 0; i < _N + 1; i++)
            {
                if (arr[_start, i] == 0)
                    continue;
                if (dfsvisited[i])
                    continue;

                DFS(_N, i);
            }
        }

        public void BFS(int _N, int _start)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(_start);

            bfsvisited[_start] = true;

            while (q.Count > 0)
            {
                int now = q.Dequeue();
                Console.Write("{0} ", now);

                for (int i = 0; i < _N + 1; i++)
                {
                    if (arr[now, i] == 0)
                        continue;
                    if (bfsvisited[i])
                        continue;

                    q.Enqueue(i);
                    bfsvisited[i] = true;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // for (int i = 1; i < N + 1; i++)
            // {
            //     for (int j = 1; j < N + 1; j++)
            //     {
            //         Console.Write(arr[i, j]);
            //     }
            //     Console.WriteLine();
            // }

            Graph graph = new Graph();

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int V = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                int row = Convert.ToInt32(Console.ReadLine());
                int cal = Convert.ToInt32(Console.ReadLine());

                graph.SetArrIndex(row, cal);
            }

            graph.DFS(N, V);
            Console.WriteLine();
            graph.BFS(N, V);
        }
    }
}