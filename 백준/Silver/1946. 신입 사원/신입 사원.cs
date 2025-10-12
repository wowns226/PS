using System;
using System.Collections.Generic;
using System.IO;

public class BOJ
{
    // https://www.acmicpc.net/problem/1946

    public class Rank  : IComparable<Rank>
    {
        public int FstRank { get; set; }
        public int SndRank { get; set; }
        public Rank(int fstRank, int sndRank)
        {
            FstRank = fstRank;
            SndRank = sndRank;
        }
        public int CompareTo(Rank? other)
        {
            if (other == null) return 1;
            return FstRank.CompareTo(other.FstRank);
        }
    }

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int T = int.Parse(sr.ReadLine());
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(sr.ReadLine());
            var ranks = new List<Rank>(N);
            for (int i = 0; i < N; i++)
            {
                var inputs = sr.ReadLine().Split();
                int fstRank = int.Parse(inputs[0]);
                int sndRank = int.Parse(inputs[1]);
                Rank grade = new Rank(fstRank, sndRank);
                ranks.Add(grade);
            }
            ranks.Sort();
            int count = 1;
            int minSndRank = ranks[0].SndRank;
            for (int i = 1; i < N; i++)
            {
                if (ranks[i].SndRank < minSndRank)
                {
                    count++;
                    minSndRank = ranks[i].SndRank;
                }
            }
            sw.WriteLine(count);
        }
    }
}