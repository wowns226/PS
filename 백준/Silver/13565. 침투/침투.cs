namespace BOJ
{
    class No_13565
    {
        const int MAX = 1002;

        static int m, n;
        static int[,] board = new int[MAX, MAX];
        static bool[,] visited = new bool[MAX, MAX];
        static Queue<(int,int)> q = new Queue<(int,int)> ();
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };

        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            m = inputs[0];
            n = inputs[1];

            for(int i=0 ;i< m;i++)
            {
                string s = Console.ReadLine();
                for(int j=0 ;j< n;j++)
                {
                    board[i, j] = int.Parse(s[j].ToString());
                }
            }

            bool flag = false;
            for(int j = 0 ; j < n ; j++)
            {
                if(board[0, j] == 0 && BFS(0, j))
                {
                    flag = true;
                    break;
                }
            }

            Console.WriteLine(flag == true ? "YES" : "NO");
        }

        static bool BFS(int x, int y)
        {
            for (int i = 0 ; i < m ; i++)
                for(int j = 0 ; j < n ; j++)
                    visited[i, j] = false;

            q.Clear();

            q.Enqueue((x, y));
            visited[x, y] = true;

            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                var curX = cur.Item1;
                var curY = cur.Item2;

                if(curX == m - 1 && board[curX, curY] == 0)
                {
                    return true;
                }

                for (int dir=0 ;dir<4 ;dir++)
                {
                    var nx = curX + dx[dir];
                    var ny = curY + dy[dir];

                    if(nx < 0 || ny < 0 || nx >= m || ny >= n) continue;
                    if(visited[nx, ny] || board[nx, ny] == 1) continue;


                    q.Enqueue((nx, ny));
                    visited[nx, ny] = true;
                }
            }

            return false;
        }
    }
}