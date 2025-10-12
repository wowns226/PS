using System;
using System.Collections.Generic;
using System.IO;

public class BOJ
{
    // https://www.acmicpc.net/problem/1946

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int T = int.Parse(sr.ReadLine());
        while(T-- > 0)
        {
            int N = int.Parse(sr.ReadLine());
            var ranks = new List<(int, int)>(N);
            for (int i = 0; i < N; i++)
            {
                var inputs = sr.ReadLine().Split();
                int fstRank = int.Parse(inputs[0]);
                int sndRank = int.Parse(inputs[1]);
                ranks.Add((fstRank, sndRank));
            }
            ranks.Sort((a, b) => a.Item1.CompareTo(b.Item1));
            int count = 1;
            int minRank = ranks[0].Item2;
            for (int i = 1; i < N; i++)
            {
                if (ranks[i].Item2 < minRank)
                {
                    count++;
                    minRank = ranks[i].Item2;
                }
            }
            sw.WriteLine(count);
        }
    }
}