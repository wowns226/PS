namespace BOJ
{
    class No_4963
    {
        const int MAX = 52;

        static int n, m, answer = 0;
        static int[,] board = new int[MAX, MAX];
        static bool[,] visited = new bool[MAX, MAX];
        static int[] dx = new int[] { 1, 0, -1, 0, 1, 1, -1, -1 };
        static int[] dy = new int[] { 0, 1, 0, -1, 1, -1, 1, -1 };
        static Queue<(int, int)> q = new Queue<(int, int)>();

        static void Main()
        {
            while(true)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                m = inputs[0];
                n = inputs[1];

                if(n == 0 && m == 0) break;

                for(int i=0 ;i<n ;i++)
                {
                    inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    for(int j=0 ;j<m ;j++)
                    {
                        board[i, j] = inputs[j];
                    }
                }

                for(int i = 0 ; i < n ; i++)
                {
                    for(int j = 0 ; j < m ; j++)
                    {
                        if(board[i,j] == 1 && !visited[i, j])
                        {
                            BFS(i, j);
                            answer++;
                        }
                    }
                }

                Console.WriteLine(answer);

                ClearAll();
            }
        }

        static void ClearAll()
        {
            answer = 0;
            q.Clear();
            for(int i = 0 ; i < n ; i++)
                for(int j = 0 ; j < m ; j++)
                    visited[i, j] = false;
        }

        static void BFS(int x, int y)
        {
            q.Enqueue((x, y));
            visited[x, y] = true;

            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                var curX = cur.Item1;
                var curY = cur.Item2;

                for (int dir=0 ;dir<8 ;dir++)
                {
                    var nx = curX + dx[dir];
                    var ny = curY + dy[dir];

                    if(nx < 0 || ny < 0 || nx >= n || ny >= m) continue;
                    if(board[nx, ny] == 0 || visited[nx, ny]) continue;

                    q.Enqueue((nx, ny));
                    visited[nx,ny] = true;
                }
            }
        }
    }
}