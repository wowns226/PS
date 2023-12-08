using System.Text;

namespace BOJ_14940
{
    class Program
    {
        
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            int[,] board = new int[n, m];
            (int, int) start = (0, 0);

            for (int i = 0; i < n; i++)
            {
                inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputs[j];

                    if (board[i, j] == 2)
                    {
                        start = (i, j);
                    }
                }
            }

            int[,] dist = new int[n, m];
            Queue<(int, int)> q = new Queue<(int, int)>();
            bool[,] visited = new bool[n, m];
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            visited[start.Item1, start.Item2] = true;
            dist[start.Item1, start.Item2] = 0;
            q.Enqueue(start);

            while (q.Count > 0)
            {
                var cur = q.Dequeue();
                var x = cur.Item1;
                var y = cur.Item2;

                for (int dir = 0; dir < 4; dir++)
                {
                    var nx = x + dx[dir];
                    var ny = y + dy[dir];

                    if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                    if (visited[nx, ny] == true) continue;
                    if (board[nx, ny] == 0) continue;

                    visited[nx, ny] = true;
                    dist[nx, ny] = dist[x, y] + 1;
                    q.Enqueue((nx, ny));
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[i, j] == 1 && dist[i,j] == 0)
                    {
                        sb.Append("-1 ");

                        continue;
                    }
                    
                    sb.Append($"{dist[i, j]} ");
                }

                sb.AppendLine();
            }

            sw.Write(sb);
        }
    }
}
