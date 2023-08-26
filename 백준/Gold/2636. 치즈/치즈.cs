namespace BOJ
{
    class No_2636
    {
        const int MAX = 102;

        static int r, c;
        static int result, time;
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };
        static int[,] board = new int[MAX, MAX];
        static bool[,] visited = new bool[MAX, MAX];
        static Queue<(int, int)> q = new Queue<(int, int)>();

        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            r = inputs[0];
            c = inputs[1];

            for(int i=0 ;i<r ;i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<c ;j++)
                {
                    board[i, j] = inputs[j];
                }
            }

            while(true)
                if(BFS())
                    break;
        }

        static bool BFS()
        {
            q.Clear();
            for(int i = 0 ; i < visited.GetLength(0) ; i++)
                for(int j = 0 ; j < visited.GetLength(1) ; j++)
                    visited[i, j] = false;
            int cnt = 0;
            time++;

            q.Enqueue((0,0));
            visited[0,0] = true;
            board[0,0] = 0;

            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                var curX = cur.Item1;
                var curY = cur.Item2;

                for(int dir = 0 ; dir < 4 ; dir++)
                {
                    var nx = curX + dx[dir];
                    var ny = curY + dy[dir];

                    if(nx < 0 || nx >= r || ny < 0 || ny >= c) continue;
                    if(visited[nx, ny]) continue;
                    if(board[nx,ny] == 0)
                    {
                        q.Enqueue((nx, ny));
                    }
                    else
                    {
                        board[nx, ny] = 0;
                        cnt++;
                    }

                    visited[nx, ny] = true;
                }
            }

            if (cnt == 0)
            {
                Console.WriteLine($"{--time}");
                Console.WriteLine(result);

                return true;
            }
            else
            {
                result = cnt;

                return false;
            }
        }
    }
}