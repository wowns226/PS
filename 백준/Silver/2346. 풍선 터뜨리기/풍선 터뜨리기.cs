using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class No_2346
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(sr.ReadLine());
        string[] inputs = sr.ReadLine().Split();

        LinkedList<(int index, int move)> deque = new LinkedList<(int, int)>();
        for (int i = 0; i < n; i++)
        {
            int move = int.Parse(inputs[i]);
            deque.AddLast((i + 1, move));
        }

        StringBuilder sb = new StringBuilder();

        var current = deque.First;
        while (deque.Count > 0)
        {
            var (idx, move) = current.Value;
            sb.Append(idx + " ");
            var temp = current;

            current = move > 0 ? current.Next ?? deque.First : current.Previous ?? deque.Last;
            deque.Remove(temp);

            if (deque.Count == 0)
                break;

            int steps = Math.Abs(move);
            for (int i = 0; i < steps - 1; i++)
            {
                current = move > 0 ? current.Next ?? deque.First : current.Previous ?? deque.Last;
            }
        }

        sw.WriteLine(sb.ToString());
    }
}