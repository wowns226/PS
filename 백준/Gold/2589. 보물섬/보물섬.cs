namespace BOJ
{
    class No_2589
    {
        const int MAX = 52;

        static int r, c;
        static char[,] arr = new char[MAX, MAX];

        static void Main()
        {
            Input();
            Solution();
        }

        static void Input()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            r = inputs[0];
            c = inputs[1];

            for(int i = 0 ; i < r ; i++)
            {
                char[] charArray = Console.ReadLine().ToCharArray();

                for(int j = 0 ; j < c ; j++)
                    arr[i, j] = charArray[j];
            }
        }

        static void Solution()
        {
            int answer = 0;

            for(int i=0 ;i<r ;i++)
            {
                for(int j=0 ;j<c ;j++)
                {
                    if(arr[i, j] == 'L')
                    {
                        answer = Math.Max(answer, BFS(i, j));
                    }
                }
            }

            Console.Write(answer);
        }

        static int BFS(int startX, int startY)
        {
            int ret = 0;

            int[] dx = new int[] { 1, 0, -1, 0 };
            int[] dy = new int[] { 0, 1, 0, -1 };

            Queue<(int, int)> q = new Queue<(int, int)>();
            int[,] dist = new int[MAX, MAX];

            q.Enqueue((startX, startY));
            dist[startX, startY] = 1;

            while(q.Count > 0)
            {
                var cur = q.Dequeue();

                var curX = cur.Item1;
                var curY = cur.Item2;

                ret = Math.Max(ret, dist[curX, curY]);

                for(int dir=0 ;dir<4 ;dir++)
                {
                    var nx = curX + dx[dir];
                    var ny = curY + dy[dir];

                    if(nx < 0 || nx >= r || ny < 0 || ny >= c) continue;
                    if(arr[nx, ny] == 'W') continue;
                    if(dist[nx, ny] > 0) continue;

                    dist[nx, ny] = dist[curX, curY] + 1;
                    q.Enqueue((nx, ny));
                }
            }

            return ret - 1;
        }
    }
}