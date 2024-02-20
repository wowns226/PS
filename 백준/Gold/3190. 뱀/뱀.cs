namespace BOJ
{
    class No_3190
    {
        static int N, K, L;
        static int[,] board;
        static Dictionary<int, char> dict = new Dictionary<int, char>();
        static LinkedList<(int, int)> snakes = new LinkedList<(int, int)>();
        static int[] dx = { 0, 1, 0, -1 };
        static int[] dy = { 1, 0, -1, 0 };

        static void Main()
        {
            N = int.Parse(Console.ReadLine());

            board = new int[N, N];

            K = int.Parse(Console.ReadLine());
            for (int i = 0; i < K; i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int x = inputs[0] - 1;
                int y = inputs[1] - 1;

                board[x, y] = 1;
            }

            L = int.Parse(Console.ReadLine());
            for (int i = 0; i < L; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int location = int.Parse(inputs[0]);
                char direction = char.Parse(inputs[1]);

                dict.TryAdd(location, direction);
            }

            snakes.AddLast((0, 0));
            int cx = 0, cy = 0;
            int d = 0;
            int timer = 0;
            while (true)
            {
                timer++;

                int nx = cx + dx[d];
                int ny = cy + dy[d];

                if (IsEnd(nx, ny)) break;

                if (board[nx, ny] == 1)
                {
                    board[nx, ny] = 0;
                    snakes.AddLast((nx, ny));
                }
                else
                {
                    snakes.AddLast((nx, ny));
                    snakes.RemoveFirst();
                }

                if (dict.ContainsKey(timer))
                {
                    if (dict[timer] == 'D')
                    {
                        d = (d + 1) % 4;
                    }
                    else
                    {
                        d = (d + 3) % 4;
                    }
                }

                cx = nx;
                cy = ny;
            }

            Console.WriteLine(timer);
        }

        static bool IsEnd(int nx, int ny)
        {
            if (nx < 0 || ny < 0 || nx >= N || ny >= N)
            {
                return true;
            }

            return snakes.Contains((nx, ny));
        }
    }
}