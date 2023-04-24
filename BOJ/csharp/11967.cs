namespace BOJ
{
    class No_11967
    {
        static int n, m;
        static int[,] board;
        static bool[,] visited;
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };
        static List<(int, int)>[,] adj;

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            n = inputs[0];
            m = inputs[1];
            board = new int[n + 1, n + 1];
            visited = new bool[n + 1, n + 1];
            adj = new List<(int, int)>[n + 1, n + 1];

            for(int i = 0 ; i < adj.GetLength(0) ; i++)
                for(int j = 0 ; j < adj.GetLength(1) ; j++)
                    adj[i, j] = new List<(int, int)>();

            while(m-- > 0)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                var (x, y) = (inputs[0], inputs[1]);
                var (a, b) = (inputs[2], inputs[3]);

                adj[x, y].Add((a, b));
            }

            BFS();

            int answer = 0;
            for(int i = 1 ; i <= n ; i++)
                for(int j = 1 ; j <= n ; j++)
                    answer += board[i, j];

            output.Write(answer);
        }

        static bool OOB(int a, int b)
        {
            return a < 1 || b < 1 || a > n || b > n;
        }

        static bool IsConnect((int, int) nxt)
        {
            for(int dir = 0 ; dir < 4 ; dir++)
            {
                int nx = nxt.Item1 + dx[dir];
                int ny = nxt.Item2 + dy[dir];

                if(OOB(nx, ny)) continue;
                if(visited[nx, ny]) return true;
            }

            return false;
        }

        static void BFS()
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            board[1, 1] = 1;
            visited[1, 1] = true;
            q.Enqueue((1, 1));

            while(q.Count > 0)
            {
                var cur = q.Dequeue();

                foreach(var nxt in adj[cur.Item1, cur.Item2])
                {
                    if(visited[nxt.Item1, nxt.Item2]) continue;
                    if(IsConnect(nxt))
                    {
                        visited[nxt.Item1, nxt.Item2] = true;
                        q.Enqueue((nxt.Item1, nxt.Item2));
                    }
                    board[nxt.Item1, nxt.Item2] = 1;
                }

                for(int dir = 0 ; dir < 4 ; dir++)
                {
                    int nx = cur.Item1 + dx[dir];
                    int ny = cur.Item2 + dy[dir];

                    if(OOB(nx, ny)) continue;
                    if(visited[nx, ny]) continue;
                    if(board[nx, ny] == 0) continue;

                    visited[nx, ny] = true;
                    q.Enqueue((nx, ny));
                }
            }
        }
    }
}