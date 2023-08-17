using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
       return BFS(maps);
    }
    
    public int BFS(int[,] maps)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            int[] dx = new int[] { 1, 0, -1, 0 };
            int[] dy = new int[] { 0, 1, 0, -1 };

            q.Enqueue((0, 0));

            while(q.Count>0)
            {
                var cur = q.Dequeue();
                var curX = cur.Item1;
                var curY = cur.Item2;

                if(curX == maps.GetLength(0) - 1 && curY == maps.GetLength(1) - 1)
                {
                    return maps[curX, curY];
                }

                for(int dir = 0 ; dir < 4 ; dir++)
                {
                    int nx = curX + dx[dir];
                    int ny = curY + dy[dir];

                    if(nx < 0 || nx >= maps.GetLength(0) || ny < 0 || ny >= maps.GetLength(1)) continue;
                    if(maps[nx, ny] != 1) continue;

                    q.Enqueue((nx, ny));
                    maps[nx, ny] = maps[curX, curY] + 1;
                }
            }

            return -1;
        }
}