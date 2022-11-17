using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1913

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int[,] board = new int[1001, 1001];
            int[] ans = new int[2];
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            int r = 0;
            int c = 0;
            int d = 0;


            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());


            int count = N * N;
            board[0, 0] = count;
            while (board[N / 2, N / 2] != 1)
            {

                int nx = r + dx[d];
                int ny = c + dy[d];
                if (nx >= N || ny >= N || nx < 0 || ny < 0 || board[nx, ny] != 0)
                {
                    d = (d + 1) % 4;
                    continue;
                }
                count--;
                board[nx, ny] = count;
                r = nx;
                c = ny;

                if (board[nx, ny] == K)
                {
                    ans[0] = nx;
                    ans[1] = ny;
                }
            }


            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    sb.Append(board[x, y]);
                    sb.Append(' ');
                }
                sb.AppendLine();
            }
            sb.Append(ans[0] + 1);
            sb.Append(' ');
            sb.Append(ans[1] + 1);

            Console.WriteLine(sb.ToString());
        }
    }
}