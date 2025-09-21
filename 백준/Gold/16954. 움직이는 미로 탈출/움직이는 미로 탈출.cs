using System;
using System.Collections.Generic;
using System.IO;

public class BOJ
{
    // https://www.acmicpc.net/problem/16954

    static readonly int[] dr = { -1, -1, -1, 0, 0, 0, 1, 1, 1 };
    static readonly int[] dc = { -1, 0, 1, -1, 0, 1, -1, 0, 1 };

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        char[][] board = new char[8][];
        for (int i = 0; i < 8; i++)
            board[i] = sr.ReadLine().ToCharArray();

        var q = new Queue<(int r, int c)>();
        q.Enqueue((7, 0));
        int level = 0;

        while (q.Count > 0)
        {
            int size = q.Count;
            var next = new HashSet<(int, int)>();

            for (int s = 0; s < size; s++)
            {
                var (r, c) = q.Dequeue();

                if (board[r][c] == '#') continue;

                if (r == 0 && c == 7)
                {
                    sw.WriteLine(1);
                    return;
                }

                for (int d = 0; d < 9; d++)
                {
                    int nr = r + dr[d];
                    int nc = c + dc[d];

                    if (nr < 0 || nr >= 8 || nc < 0 || nc >= 8) continue;
                    if (board[nr][nc] == '#') continue;

                    if (nr - 1 >= 0 && board[nr - 1][nc] == '#') continue;

                    if (!next.Contains((nr, nc)))
                        next.Add((nr, nc));
                }
            }

            foreach (var p in next)
                q.Enqueue(p);

            MoveWallsDown(board);

            level++;

            if (level >= 8)
            {
                sw.WriteLine(1);
                return;
            }
        }

        sw.WriteLine(0);
    }

    static void MoveWallsDown(char[][] b)
    {
        for (int r = 7; r >= 1; r--)
            b[r] = (char[])b[r - 1].Clone();
        b[0] = new string('.', 8).ToCharArray();
    }
}