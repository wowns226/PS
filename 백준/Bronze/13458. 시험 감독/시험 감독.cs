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
            if (a[i] <= b[0])
            {
                result++;
            }
            else
            {
                result++;
                a[i] -= b[0];
                if (a[i] > 0)
                {
                    if (a[i] % b[1] > 0)
                        result += (a[i] / b[1]) + 1;
                    else
                        result += a[i] / b[1];
                }
            }
        }

        sw.WriteLine(result);
    }
}