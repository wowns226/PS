using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class BOJ
{
    // https://www.acmicpc.net/problem/17837

    public class Piece
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Direction { get; set; }
        public Piece(int row, int col, int direction)
        {
            Row = row;
            Col = col;
            Direction = direction;
        }
    }

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int N = inputs[0];
        int K = inputs[1];

        int[,] board = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            int[] row = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            for (int j = 0; j < N; j++)
            {
                board[i, j] = row[j];
            }
        }

        List<Piece> pieces = new List<Piece>();
        List<int>[,] piecePositions = new List<int>[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                piecePositions[i, j] = new List<int>();
            }
        }

        for (int i = 0; i < K; i++)
        {
            int[] pieceInfo = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int row = pieceInfo[0] - 1;
            int col = pieceInfo[1] - 1;
            int direction = pieceInfo[2] - 1;
            pieces.Add(new Piece(row, col, direction));
            piecePositions[row, col].Add(i);
        }

        int[] dRow = { 0, 0, -1, 1 };
        int[] dCol = { 1, -1, 0, 0 };
        int turn = 0;

        while (turn < 1000)
        {
            turn++;
            for (int i = 0; i < K; i++)
            {
                Piece piece = pieces[i];
                int currentRow = piece.Row;
                int currentCol = piece.Col;
                int direction = piece.Direction;
                int indexInStack = piecePositions[currentRow, currentCol].IndexOf(i);
                if (indexInStack == -1) continue;
                int newRow = currentRow + dRow[direction];
                int newCol = currentCol + dCol[direction];
                if (newRow < 0 || newRow >= N || newCol < 0 || newCol >= N || board[newRow, newCol] == 2)
                {
                    piece.Direction = direction % 2 == 0 ? direction + 1 : direction - 1;
                    direction = piece.Direction;
                    newRow = currentRow + dRow[direction];
                    newCol = currentCol + dCol[direction];
                    if (newRow < 0 || newRow >= N || newCol < 0 || newCol >= N || board[newRow, newCol] == 2)
                    {
                        continue;
                    }
                }
                List<int> movingPieces = piecePositions[currentRow, currentCol].GetRange(indexInStack, piecePositions[currentRow, currentCol].Count - indexInStack);
                piecePositions[currentRow, currentCol].RemoveRange(indexInStack, piecePositions[currentRow, currentCol].Count - indexInStack);
                if (board[newRow, newCol] == 1)
                {
                    movingPieces.Reverse();
                }
                foreach (int p in movingPieces)
                {
                    pieces[p].Row = newRow;
                    pieces[p].Col = newCol;
                    piecePositions[newRow, newCol].Add(p);
                }
                if (piecePositions[newRow, newCol].Count >= 4)
                {
                    sw.WriteLine(turn);
                    return;
                }
            }
        }
        
        sw.WriteLine(-1);
    }
}