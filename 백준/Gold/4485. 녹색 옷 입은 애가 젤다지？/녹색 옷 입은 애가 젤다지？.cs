namespace BOJ_4485
{
    class Program
    {
        static void Main()
        {
            int index = 1;
            
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0) break;

                int[,] board = new int[n,n];
                int[,] dist = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dist[i, j] = int.MaxValue;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    for (int j = 0; j < n; j++)
                    {
                        board[i, j] = inputs[j];
                    }
                }

                Queue<(int, int)> q = new Queue<(int, int)>();
                int[] dx = new[] { 1, 0, -1, 0 };
                int[] dy = new[] { 0, 1, 0, -1 };
                q.Enqueue((0, 0));
                dist[0, 0] = board[0, 0];

                while (q.Count > 0)
                {
                    var cur = q.Dequeue();
                    var curX = cur.Item1;
                    var curY = cur.Item2;

                    for (int dir = 0; dir < 4; dir++)
                    {
                        int nx = curX + dx[dir];
                        int ny = curY + dy[dir];

                        if (nx < 0 || ny < 0 || nx >= n || ny >= n) continue;
                        if (dist[nx, ny] > dist[curX, curY] + board[nx, ny])
                        {
                            dist[nx, ny] = dist[curX, curY] + board[nx, ny];
                            q.Enqueue((nx,ny));
                        }
                    }
                }

                Console.WriteLine($"Problem {index++}: {dist[n - 1, n - 1]}");
            }
        }
    }
}
