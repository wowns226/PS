namespace BOJ
{
    class No_1743
    {
        const int MAX = 102;

        static int n, m, k, answer = 0;
        static int[,] board = new int[MAX, MAX];
        static bool[,] visited = new bool[MAX, MAX];
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };
        static Queue<(int, int)> q = new Queue<(int, int)>();

        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = inputs[0];
            m = inputs[1];
            k = inputs[2];

            for(int count=0 ;count<k ;count++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                board[inputs[0] - 1, inputs[1] - 1] = 1;
            }
            
            for(int i=0 ;i<n ;i++)
            {
                for(int j=0 ;j<m ;j++)
                {
                    if(board[i, j] == 1 && !visited[i, j])
                        answer = Math.Max(answer, BFS(i, j));
                }
            }

            Console.WriteLine(answer);
        }

        static int BFS(int x, int y)
        {
            int count = 1;

            q.Enqueue((x, y));
            visited[x, y] = true;

            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                var curX = cur.Item1;
                var curY = cur.Item2;

                for (int dir=0 ;dir<4 ;dir++)
                {
                    var nx = curX + dx[dir];
                    var ny = curY + dy[dir];

                    if(nx < 0 || ny < 0 || nx >= n || ny >= m) continue;
                    if(board[nx, ny] != 1 || visited[nx, ny]) continue;

                    q.Enqueue((nx, ny));
                    visited[nx,ny] = true;
                    count++;
                }
            }

            return count;
        }
    }
}