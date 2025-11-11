using System;
using System.IO;
using System.Linq;

public class BOJ
{
    // https://www.acmicpc.net/problem/1449

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] inputs;

        inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
        int N = inputs[0];
        int L = inputs[1];

        inputs = sr.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
        int[] locations = new int[N];

        for (int i = 0; i < N; i++)
            locations[i] = inputs[i];

        if (L == 1)
        {
            sw.WriteLine(N);
            return;
        }

        int answer = 0;
        double last = -1;

        foreach (int location in locations)
        {
            if(location > last)
            {
                answer++;
                last = location + L - 0.5;
            }
        }

        sw.WriteLine(answer);
    }
}