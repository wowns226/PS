using System;
using System.IO;

public class No_1189
{
    static int R, C, K, result = 0;
    static char[,] map;
    static bool[,] visited;
    static int[] dx = { 1, -1, 0, 0 };
    static int[] dy = { 0, 0, 1, -1 };

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var input = sr.ReadLine().Split();
        R = int.Parse(input[0]);
        C = int.Parse(input[1]);
        K = int.Parse(input[2]);

        map = new char[R, C];
        visited = new bool[R, C];

        for (int i = 0; i < R; i++)
        {
            string line = sr.ReadLine();
            for (int j = 0; j < C; j++)
            {
                map[i, j] = line[j];
            }
        }

        visited[R - 1, 0] = true;
        DFS(R - 1, 0, 1);

        sw.WriteLine(result);
    }

    static void DFS(int x, int y, int dist)
    {
        if (x == 0 && y == C - 1)
        {
            if (dist == K)
                result++;
            return;
        }

        for (int dir = 0; dir < 4; dir++)
        {
            int nx = x + dx[dir];
            int ny = y + dy[dir];

            if (nx < 0 || ny < 0 || nx >= R || ny >= C) continue;
            if (map[nx, ny] == 'T' || visited[nx, ny]) continue;

            visited[nx, ny] = true;
            DFS(nx, ny, dist + 1);
            visited[nx, ny] = false;
        }
    }
}