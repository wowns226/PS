namespace BOJ_25756
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(Console.ReadLine());

            int[] inputs;

            int[,] board = new int[n, n];
            (int, int) runner = (0, 0), boss = (0, 0);

            for (int i = 0; i < n; i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = inputs[j];

                    if (board[i, j] == 2)
                    {
                        runner = (i, j);
                    }
                    else if (board[i, j] == 5)
                    {
                        boss = (i, j);
                    }
                }
            }

            // 도망 침
            if (CanRun(runner, boss, board))
            {
                sw.Write('1');
            }
            // 도망 못침
            else
            {
                sw.Write('0');
            }
        }

        static bool CanRun((int,int) a, (int,int) b, int[,] board)
        {
            // 거리가 5 이상이면 도망
            int dx = a.Item1 - b.Item1;
            int dy = a.Item2 - b.Item2;
            
            // 교수와 성규를 꼭짓점으로하는 축과 평행한 직사각형 안에 학생이 3명 이상
            int count = 0;
            for (int i = Min(a.Item1, b.Item1); i <= Max(a.Item1, b.Item1); i++)
            {
                for (int j = Min(a.Item2, b.Item2); j <= Max(a.Item2, b.Item2); j++)
                {
                    if (board[i, j] == 1)
                    {
                        count++;
                    }
                }
            }

            if ((dx * dx + dy * dy) >= 25 && count >= 3)
            {
                return true;
            }

            return false;
        }
        
        static int Min(int a, int b) => Math.Min(a, b);
        static int Max(int a, int b) => Math.Max(a, b);
    }
}
