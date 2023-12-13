using System.Text;

namespace BOJ_16918
{
    public static class StringBuilderExtension
    {
        public static string Append2DArrayToString(char[,] array)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    stringBuilder.Append(array[i, j]);
                }

                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
    
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            
            
            int[] inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int R = inputs[0];
            int C = inputs[1];
            int N = inputs[2];

            char[,] board = new char[R, C];
            char[,] bombBoard = new char[R, C];

            for (int i = 0; i < R; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < C; j++)
                {
                    board[i, j] = s[j];
                    bombBoard[i, j] = 'O';
                }
            }

            char[,] bomberFirstBoard = Bomberman(R, C, board);
            char[,] bomberSecondBoard = Bomberman(R, C, bomberFirstBoard);

            // 1일 때 원본
            if (N == 1)
            {
                sw.WriteLine(StringBuilderExtension.Append2DArrayToString(board));
            }

            // 짝수 일때 전부 폭탄
            else if (N % 2 == 0)
            {
                sw.WriteLine(StringBuilderExtension.Append2DArrayToString(bombBoard));
            }

            else switch (N % 4)
            {
                // 3 7 11 15 ...
                case 3:
                    sw.WriteLine(StringBuilderExtension.Append2DArrayToString(bomberFirstBoard));

                    break;
                // 5 9 13 17 ...
                case 1:
                    sw.WriteLine(StringBuilderExtension.Append2DArrayToString(bomberSecondBoard));

                    break;
            }
        }

        static char[,] Bomberman(int R, int C, char[,] board)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            char[,] newBoard = new char[R, C];
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };
            
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (board[i, j] == 'O')
                    {
                        q.Enqueue((i, j));
                        newBoard[i, j] = '.';
                    }
                    else 
                        newBoard[i, j] = 'O';
                    
                }
            }

            while (q.Count > 0)
            {
                (int x, int y) = q.Dequeue();

                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = x + dx[dir];
                    int ny = y + dy[dir];

                    if (nx < 0 || nx >= R || ny < 0 || ny >= C) continue;

                    newBoard[nx, ny] = '.';
                }
            }

            return newBoard;
        }
    }
}

