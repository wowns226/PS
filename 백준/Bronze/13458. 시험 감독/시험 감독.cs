using System;
using System.IO;
using System.Linq;

public class No_13458
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));


        int n = int.Parse(sr.ReadLine());
        int[] a = sr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = sr.ReadLine().Split().Select(int.Parse).ToArray();

        long result = 0;
        for (int i = 0; i < n; i++)
        {
            result++; // 총감독관은 무조건 1명
            int remain = a[i] - b[0];
            if (remain > 0)
                result += (remain + b[1] - 1) / b[1]; // 부감독관 수 (올림)
        }

        sw.WriteLine(result);
    }
}