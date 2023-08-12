namespace BOJ
{
    class No_1590
    {
        static int n, m;
        static int[] dx = new int[] { 1, 0, -1, 0 };
        static int[] dy = new int[] { 0, 1, 0, -1 };
        static int[,] arr = new int[500, 500];
        static int[,] cnt = new int[500, 500];

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            n = inputs[0];
            m = inputs[1];

            for(int i=0 ;i<n ;i++)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

                for(int j=0 ;j<m ;j++)
                {
                    arr[i, j] = inputs[j];
                    cnt[i, j] = -1;
                }
            }

            cnt[0, 0] = 1;

            output.WriteLine(DFS(n - 1, m - 1));
        }

        static int DFS(int x, int y)
        {
            if(cnt[x, y] != -1) return cnt[x, y];

            cnt[x, y] = 0;
            for(int dir=0 ;dir<4 ;dir++)
            {
                int nx = x + dx[dir];
                int ny = y + dy[dir];

                if(nx>=0 && nx < n && ny >= 0 && ny < m)
                {
                    if(arr[x, y] < arr[nx, ny])
                    {
                        cnt[x, y] += DFS(nx, ny);
                    }
                }
            }

            return cnt[x, y];
        }
    }
}

