using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class No_2578
{
    public class Cell
    {
        public int X;
        public int Y;
        public bool IsCalled;
    }

    public class Board
    {
        private readonly Dictionary<int, Cell> _cells = new();

        public void AddCell(int number, int x, int y)
        {
            _cells[number] = new Cell { X = x, Y = y, IsCalled = false };
        }

        public void MarkNumber(int number)
        {
            if (_cells.ContainsKey(number))
                _cells[number].IsCalled = true;
        }

        public int CountBingos()
        {
            int count = 0;

            for (int x = 0; x < 5; x++)
                if (CheckLine(cell => cell.X == x)) count++;

            for (int y = 0; y < 5; y++)
                if (CheckLine(cell => cell.Y == y)) count++;

            if (CheckLine(cell => cell.X == cell.Y)) count++;
            if (CheckLine(cell => cell.X + cell.Y == 4)) count++;

            return count;
        }

        private bool CheckLine(Func<Cell, bool> predicate) => _cells.Values.Where(predicate).Count(c => c.IsCalled) == 5;
    }

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var board = new Board();

        for (int i = 0; i < 5; i++)
        {
            int[] row = sr.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < 5; j++)
            {
                board.AddCell(row[j], i, j);
            }
        }

        int callCount = 0;
        for (int i = 0; i < 5; i++)
        {
            int[] calls = sr.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (int number in calls)
            {
                callCount++;
                board.MarkNumber(number);

                if (board.CountBingos() >= 3)
                {
                    sw.WriteLine(callCount);
                    return;
                }
            }
        }
    }
}