using System;
using System.IO;
using System.Linq;

public class No_13164
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();

        int n = inputs[0];
        int k = inputs[1];

        int[] heights = sr.ReadLine().Split().Select(int.Parse).ToArray();

        if (n <= k)
        {
            sw.WriteLine(0);
            return;
        }

        long[] diffs = new long[n - 1];
        for (int i = 0; i < n - 1; i++)
        {
            diffs[i] = heights[i + 1] - heights[i];
        }

        Array.Sort(diffs);

        long result = 0;
        for (int i = 0; i < n - k; i++)
        {
            result += diffs[i];
        }

        sw.WriteLine(result);
    }
}