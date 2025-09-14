using System;
using System.Collections.Generic;
using System.IO;

public class BOJ
{
    // https://www.acmicpc.net/problem/1260

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int n = inputs[0];
        int m = inputs[1];
        int v = inputs[2];

        int[,] graph = new int[n + 1, n + 1];
        for (int i = 0; i < m; i++)
        {
            int[] edge = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            graph[edge[0], edge[1]] = 1;
            graph[edge[1], edge[0]] = 1;
        }

        bool[] visited = new bool[n + 1];
        DFS(v, n, graph, visited, sw);
        sw.WriteLine();
        visited = new bool[n + 1];
        BFS(v, n, graph, visited, sw);
    }

    private static void DFS(int v, int n, int[,] graph, bool[] visited, StreamWriter sw)
    {
        var stack = new Stack<int>();
        stack.Push(v);
        while (stack.Count > 0)
        {
            int node = stack.Pop();
            if (!visited[node])
            {
                visited[node] = true;
                sw.Write(node + " ");
                for (int i = n; i >= 1; i--)
                {
                    if (graph[node, i] == 1 && !visited[i])
                    {
                        stack.Push(i);
                    }
                }
            }
        }
    }

    private static void BFS(int v, int n, int[,] graph, bool[] visited, StreamWriter sw)
    {
        var queue = new Queue<int>();
        queue.Enqueue(v);
        visited[v] = true;
        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            sw.Write(node + " ");
            for (int i = 1; i <= n; i++)
            {
                if (graph[node, i] == 1 && !visited[i])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                }
            }
        }
    }
}