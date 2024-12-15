namespace BOJ
{    
    class No_16509
    {
        static void Main()
        {
            int[] shang = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] king = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            const int row = 10;
            const int col = 9;
            int[,] board = new int[row, col];

            board[shang[0], shang[1]] = 1;
            board[king[0], king[1]] = -1;

            Queue<(int, int)> q = new Queue<(int, int)>();
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };
            int[] ddx = { 2, 2, 2, -2, -2, -2, 2, -2 };
            int[] ddy = { 2, -2, 2, 2, 2, -2, -2, -2 };

            q.Enqueue((shang[0], shang[1]));

            while (q.Count > 0)
            {
                var cur = q.Dequeue();

                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = cur.Item1 + dx[dir];
                    int ny = cur.Item2 + dy[dir];

                    if (nx < 0 || ny < 0 || nx >= row || ny >= col) continue;
                    if (board[nx, ny] == -1) continue;

                    for (int ddir = dir * 2; ddir <= dir * 2 + 1; ddir++)
                    {
                        int nnx = nx + ddx[ddir];
                        int nny = ny + ddy[ddir];

                        if (nnx < 0 || nny < 0 || nnx >= row || nny >= col) continue;
                        if (board[nx + (ddx[ddir] / 2), ny + (ddy[ddir] / 2)] == -1) continue;
                        if (board[nnx, nny] == -1)
                        {
                            Console.WriteLine(board[cur.Item1, cur.Item2]);
                            return;
                        }
                        
                        board[nnx, nny] = board[cur.Item1, cur.Item2]+1;
                        q.Enqueue((nnx, nny));
                    }
                }
            }

            Console.WriteLine(-1);
        }
    }
}