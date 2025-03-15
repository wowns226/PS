using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static int n, k;
    static string[] cards;
    static HashSet<string> numbers = new HashSet<string>();

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sw.Write(Solve(sr));
    }

    private static string Solve(StreamReader sr)
    {
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());

        cards = new string[n];
        for (int i = 0; i < n; i++)
        {
            cards[i] = Console.ReadLine();
        }

        Permute(new List<string>(), new bool[n]);

        return numbers.Count.ToString();
    }

    static void Permute(List<string> selected, bool[] used)
    {
        if (selected.Count == k)
        {
            numbers.Add(string.Join("", selected));
            return;
        }

        for (int i = 0; i < n; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                selected.Add(cards[i]);
                Permute(selected, used);
                selected.RemoveAt(selected.Count - 1);
                used[i] = false;
            }
        }
    }
}