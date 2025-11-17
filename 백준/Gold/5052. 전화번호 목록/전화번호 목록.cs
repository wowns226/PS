using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class BOJ
{
    // https://www.acmicpc.net/problem/5052

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        StringBuilder sb = new StringBuilder();
        int T = int.Parse(sr.ReadLine());
        while (T-- > 0)
        {
            int N = int.Parse(sr.ReadLine());
            List<string> phones = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string phone = sr.ReadLine();

                phones.Add(phone);
            }

            phones.Sort();

            bool isConsistent = true;
            for (int i = 0; i < N - 1; i++)
            {
                if (phones[i + 1].StartsWith(phones[i]))
                {
                    isConsistent = false;
                    break;
                }
            }

            sb.AppendLine(isConsistent ? "YES" : "NO");
        }

        sw.WriteLine(sb.ToString());
    }
}