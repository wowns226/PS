using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/4396
// 참고 : https://velog.io/@besyia0k0/%EB%B0%B1%EC%A4%80-4396

namespace BOJ
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static char[,] board = new char[11, 11];
        static char[,] opened = new char[11,11];
        static int n;
        static bool isCheck;

        static int CheckAroundMine(int _x, int _y)
        {
            int[] dx = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] dy = { -1, 0, 1, 1, 1, 0, -1, -1 };
            int nx, ny, count = 0;

            for(int d = 0 ; d < 8 ; d++)
            {
                nx = _x + dx[d];
                ny = _y + dy[d];

                if(nx < 0 || ny < 0 || nx >= n || ny >= n) continue;

                if(board[nx, ny] == '*')
                {
                    count++;
                }
            }

            return count;
        }

        static void Main()
        {
            n = int.Parse(Console.ReadLine());

            for(int i = 0 ; i < n ; i++)
            {
                string s = Console.ReadLine();

                for(int j = 0 ; j < s.Length ; j++)
                {
                    board[i, j] = s[j];
                }
            }

            for(int i = 0 ; i < n ; i++)
            {
                string s = Console.ReadLine();

                for(int j = 0 ; j < s.Length ; j++)
                {
                    opened[i, j] = s[j];
                }

                if(!isCheck)
                {
                    for(int j = 0 ; j < s.Length ; j++)
                    {
                        if(opened[i, j] == 'x' && board[i, j] == '*')
                        {
                            isCheck = true;
                            break;
                        }
                    }
                }
            }

            for(int x = 0 ; x < n ; x++) 
            {
                for(int y = 0 ; y < n ; y++) 
                {
                    if(opened[x, y] == 'x')
                    {
                        if(board[x, y] == '*')
                        {
                            sb.Append(board[x, y]);
                        }
                        else
                        {
                            sb.Append(CheckAroundMine(x,y).ToString());
                        }
                    }
                    else if (isCheck)
                    {
                        sb.Append(board[x, y]);
                    }
                    else
                    {
                        sb.Append('.');
                    }
                }
                sb.Append('\n');
            }

            Console.WriteLine(sb.ToString());
        }
    }
}