using System.Text;

namespace BOJ_2630
{
    class Program
    {
        static int white = 0, blue = 0;
        
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(sr.ReadLine());

            int[,] board = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                var inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = inputs[j];
                }
            }

            DFS(0, 0, N, board);

            sb.AppendLine(white.ToString());
            sb.AppendLine(blue.ToString());
            
            sw.Write(sb);
        }

        static void DFS(int x, int y, int n, int[,] board)
        {
            if (IsSameColor(x, y, n, board))
            {
                CountColor(board[x, y]);
            }
            else
            {
                int newN = n >> 1;

                DFS(x, y, newN, board);
                DFS(x + newN, y, newN, board);
                DFS(x, y + newN, newN, board);
                DFS(x + newN, y + newN, newN, board);
            }
        }

        static bool IsSameColor(int x, int y, int n, int[,] board)
        {
            int color = board[x, y];
            for (int i = x; i < x + n; i++)
            {
                for (int j = y; j < y + n; j++)
                {
                    if (board[i, j] != color)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void CountColor(int color)
        {
            if (color == 0) white++;
            else blue++;
        }

    }
}
