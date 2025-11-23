using System;
using System.IO;

public class BOJ
{
    // https://www.acmicpc.net/problem/1652

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int N = int.Parse(sr.ReadLine());
        char[][] map = new char[N][];

        for (int i = 0; i < N; i++)
        {
            map[i] = sr.ReadLine().ToCharArray();
        }

        int horizontalCount = 0;
        for (int i = 0; i < N; i++)
        {
            int count = 0;
            for (int j = 0; j < N; j++)
            {
                if (map[i][j] == '.')
                {
                    count++;
                }
                else
                {
                    if (count >= 2)
                    {
                        horizontalCount++;
                    }
                    count = 0;
                }
            }
            if (count >= 2)
            {
                horizontalCount++;
            }
        }

        int verticalCount = 0;
        for (int j = 0; j < N; j++)
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (map[i][j] == '.')
                {
                    count++;
                }
                else
                {
                    if (count >= 2)
                    {
                        verticalCount++;
                    }
                    count = 0;
                }
            }
            if (count >= 2)
            {
                verticalCount++;
            }
        }

        sw.WriteLine($"{horizontalCount} {verticalCount}");
    }
}