namespace BOJ
{
    class No_3055
    {
        const int MAX = 52;

        static int r, c;
        static char[,] board = new char[MAX, MAX];
        static int[,] dist1 = new int[MAX, MAX];
        static int[,] dist2 = new int[MAX, MAX];
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };
        static Queue<(int, int)> q1 = new Queue<(int, int)>();
        static Queue<(int, int)> q2 = new Queue<(int, int)>();

        static void Main()
        {


            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            r = inputs[0];
            c = inputs[1];
            (int, int) startPos = (0, 0);
            (int, int) endPos = (0, 0);

            for(int i=0 ;i<r ;i++)
            {
                string s = Console.ReadLine();
                for(int j=0 ;j<c ;j++)
                {
                    board[i, j] = s[j];

                    if(board[i, j] == '*')
                    {
                        dist1[i, j] = 1;
                        q1.Enqueue((i, j));
                    }
                    else if(board[i, j] == 'D')
                    {
                        endPos = (i, j);

                    }
                    else if(board[i, j] == 'S')
                    {
                        startPos = (i, j);
                        dist2[i, j] = 1;
                        q2.Enqueue((i, j));
                    }
                }
            }

            while(q1.Count>0)
            {
                var cur = q1.Dequeue();
                var curX = cur.Item1;
                var curY = cur.Item2;

                for(int dir=0 ;dir<4 ;dir++)
                {
                    var nx = curX + dx[dir];
                    var ny = curY + dy[dir];

                    if(nx < 0 || ny < 0 || nx >= r || ny >= c) continue;
                    if(board[nx, ny] != '.' || dist1[nx,ny] != 0) continue;

                    dist1[nx, ny] = dist1[curX, curY] + 1;
                    q1.Enqueue((nx, ny));
                }
            }
            
            while(q2.Count>0)
            {
                var cur = q2.Dequeue();
                var curX = cur.Item1;
                var curY = cur.Item2;

                for(int dir=0 ;dir<4 ;dir++)
                {
                    var nx = curX + dx[dir];
                    var ny = curY + dy[dir];

                    if(nx < 0 || ny < 0 || nx >= r || ny >= c) continue;
                    if(dist2[nx, ny] != 0) continue;
                    if(board[nx,ny] == '.' || board[nx,ny] == 'D')
                    {
                        if(dist1[nx,ny] == 0)
                        {
                            dist2[nx, ny] = dist2[curX, curY] + 1;
                            q2.Enqueue((nx, ny));
                        }
                        else
                        {
                            if(dist1[nx, ny] > dist2[curX,curY]+1)
                            {
                                dist2[nx, ny] = dist2[curX, curY] + 1;
                                q2.Enqueue((nx, ny));
                            }
                        }
                    }
                }
            }

            Console.WriteLine(dist2[endPos.Item1, endPos.Item2] != 0 ? dist2[endPos.Item1, endPos.Item2]-1 : "KAKTUS");
        }
    }
}