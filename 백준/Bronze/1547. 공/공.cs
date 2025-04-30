using System;
using System.IO;

public class No_1547
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] cups = { 1, 2, 3 };
        int m = int.Parse(sr.ReadLine());

        for (int i = 0; i < m; i++)
        {
            var inputs = sr.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            int idxA = Array.IndexOf(cups, a);
            int idxB = Array.IndexOf(cups, b);

            (cups[idxA], cups[idxB]) = (cups[idxB], cups[idxA]);
        }

        Console.WriteLine(cups[0]);
    }
}