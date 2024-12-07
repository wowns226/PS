using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] game_board, int[,] table) {
            int n = game_board.GetLength(0);
            int filled = 0;

            bool[,] boardVisited = new bool[n, n];
            List<int[,]> emptySpaces = ExtractBlocks(game_board, boardVisited, 0);

            bool[,] tableVisited = new bool[n, n];
            List<int[,]> tableBlocks = ExtractBlocks(table, tableVisited, 1);

            bool[] usedBlocks = new bool[tableBlocks.Count];
            foreach (var space in emptySpaces)
            {
                for (int i = 0; i < tableBlocks.Count; i++)
                {
                    if (usedBlocks[i]) continue;
                    var block = tableBlocks[i];

                    for (int rotation = 0; rotation < 4; rotation++)
                    {
                        if (BlocksMatch(space, block))
                        {
                            filled += CountCells(block);
                            usedBlocks[i] = true;
                            break;
                        }
                        block = Rotate(block);
                    }

                    if (usedBlocks[i]) break;
                }
            }

            return filled;
    }
    
    public static List<int[,]> ExtractBlocks(int[,] board, bool[,] visited, int target)
    {
        int n = board.GetLength(0);
        List<int[,]> blocks = new List<int[,]>();
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i, j] == target && !visited[i, j])
                {
                    Queue<(int, int)> q = new Queue<(int, int)>();
                    q.Enqueue((i, j));
                    visited[i, j] = true;

                    List<(int, int)> cells = new List<(int, int)>();
                    cells.Add((i, j));

                    int minX = i, minY = j, maxX = i, maxY = j;

                    while (q.Count > 0)
                    {
                        var (x, y) = q.Dequeue();
                        for (int dir = 0; dir < 4; dir++)
                        {
                            int nx = x + dx[dir];
                            int ny = y + dy[dir];

                            if (nx < 0 || ny < 0 || nx >= n || ny >= n) continue;
                            if (visited[nx, ny] || board[nx, ny] != target) continue;

                            visited[nx, ny] = true;
                            q.Enqueue((nx, ny));
                            cells.Add((nx, ny));

                            minX = Math.Min(minX, nx);
                            minY = Math.Min(minY, ny);
                            maxX = Math.Max(maxX, nx);
                            maxY = Math.Max(maxY, ny);
                        }
                    }

                    int[,] block = new int[maxX - minX + 1, maxY - minY + 1];                    
                    for(int k=0;k<cells.Count;k++)
                    {
                        block[cells[k].Item1 - minX, cells[k].Item2 - minY] = 1;
                    }

                    blocks.Add(block);
                }
            }
        }

        return blocks;
    }

    public static int[,] Rotate(int[,] block)
    {
        int rows = block.GetLength(0);
        int cols = block.GetLength(1);
        int[,] rotated = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rotated[j, rows - 1 - i] = block[i, j];
            }
        }

        return rotated;
    }

    public static bool BlocksMatch(int[,] space, int[,] block)
    {
        if (space.GetLength(0) != block.GetLength(0) || space.GetLength(1) != block.GetLength(1))
            return false;

        for (int i = 0; i < space.GetLength(0); i++)
        {
            for (int j = 0; j < space.GetLength(1); j++)
            {
                if (space[i, j] != block[i, j])
                    return false;
            }
        }

        return true;
    }

    public static int CountCells(int[,] block)
    {
        int count = 0;
        for (int i = 0; i < block.GetLength(0); i++)
        {
            for (int j = 0; j < block.GetLength(1); j++)
            {
                if (block[i, j] == 1) count++;
            }
        }
        return count;
    }
}