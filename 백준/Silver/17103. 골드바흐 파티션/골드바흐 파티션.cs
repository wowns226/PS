using System;
using System.IO;

public class No_17103
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int t = int.Parse(sr.ReadLine());
        int maxN = 1000000;
        bool[] isPrime = new bool[maxN + 1];
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false;

        // 에라토스테네스의 체
        for (int i = 2; i * i <= maxN; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= maxN; j += i)
                    isPrime[j] = false;
            }
        }

        for (int tc = 0; tc < t; tc++)
        {
            int n = int.Parse(sr.ReadLine());
            int count = 0;
            for (int a = 2; a <= n / 2; a++)
            {
                int b = n - a;
                if (isPrime[a] && isPrime[b])
                    count++;
            }
            sw.WriteLine(count);
        }
    }
}