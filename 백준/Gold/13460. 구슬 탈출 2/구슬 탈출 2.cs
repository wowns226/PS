using System;
using System.Collections.Generic;
using System.Linq;

namespace BOJ_13460
{
    class Program
    {
        const int MAX_MOVE_COUNT = 10;

        static int n, m;
        static char[,] board;

        static void Main()
        {
            int d = -1, moveCount = 0;
            (int, int) redPos = (0, 0), bluePos = (0, 0), endPos = (0, 0);

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = inputs[0];
            m = inputs[1];

            board = new char[n, m];
            for(int i=0 ;i<n ;i++)
            {
                string s = Console.ReadLine();
                for(int j=0 ;j<m ;j++)
                {
                    board[i, j] = s[j];

                    if(board[i, j] == 'R') redPos = (i, j);
                    else if(board[i,j] == 'B') bluePos = (i, j);
                    else if(board[i,j] == 'O') endPos = (i, j);
                }
            }

            int answer = BFS(redPos, bluePos);
            Console.WriteLine(answer);
        }

        static int BFS((int, int) redPos, (int, int) bluePos)
        {
            int[] dx = new int[] { 1, 0, -1, 0 };
            int[] dy = new int[] { 0, 1, 0, -1 };
            Queue<(int, int, int, int, int)> q = new Queue<(int, int, int, int, int)>();

            q.Enqueue((redPos.Item1, redPos.Item2, bluePos.Item1, bluePos.Item2, 0));

            while(q.Count > 0)
            {
                var cur = q.Dequeue();
                int curRedX = cur.Item1;
                int curRedY = cur.Item2;
                int curBlueX = cur.Item3;
                int curBlueY = cur.Item4;
                int curMoveCount = cur.Item5;

                // 10번 움직인 경우
                if(curMoveCount == MAX_MOVE_COUNT)
                    break;

                for(int dir = 0 ; dir < 4 ; dir++)
                {
                    int nextRedX = curRedX;
                    int nextRedY = curRedY;
                    int nextBlueX = curBlueX;
                    int nextBlueY = curBlueY;

                    // 이동 가능한 만큼 이동 (벽이 아니고 구멍이 아닌경우)
                    // 빨간색 이동
                    while(board[nextRedX + dx[dir], nextRedY + dy[dir]] != '#' && board[nextRedX, nextRedY] != 'O')
                    {
                        nextRedX += dx[dir];
                        nextRedY += dy[dir];
                    }

                    // 파란색 이동
                    while(board[nextBlueX + dx[dir], nextBlueY + dy[dir]] != '#' && board[nextBlueX, nextBlueY] != 'O')
                    {
                        nextBlueX += dx[dir];
                        nextBlueY += dy[dir];
                    }

                    if(board[nextBlueX, nextBlueY] == 'O') continue; // 파란 구슬이 구멍에 빠진 경우 무시

                    if(board[nextRedX, nextRedY] == 'O') return curMoveCount + 1; // 빨간 구슬이 구멍에 도달한 경우

                    if(nextRedX == nextBlueX && nextRedY == nextBlueY) // 빨간 구슬과 파란 구슬이 같은 위치에 있을 경우
                    {
                        int redDist = Math.Abs(nextRedX - curRedX) + Math.Abs(nextRedY - curRedY);
                        int blueDist = Math.Abs(nextBlueX - curBlueX) + Math.Abs(nextBlueY - curBlueY);

                        // 빨간 구슬의 이동 거리가 파란 구슬보다 먼 경우
                        // 파란 구슬을 현재 방향으로 이동시키기 위해 수정
                        if(redDist > blueDist)
                        {
                            nextRedX -= dx[dir];
                            nextRedY -= dy[dir];
                        }
                        // 파란 구슬의 이동 거리가 빨간 구슬보다 먼 경우
                        // 빨간 구슬을 현재 방향으로 이동시키기 위해 수정
                        else
                        {
                            nextBlueX -= dx[dir];
                            nextBlueY -= dy[dir];
                        }
                    }

                    q.Enqueue((nextRedX, nextRedY, nextBlueX, nextBlueY, curMoveCount + 1));
                }
            }

            return -1; // 10번 이상 움직여서 성공하지 못한 경우
        }
    }
}
