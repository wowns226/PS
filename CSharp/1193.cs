using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1193

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(ReadLine());
            int i = 1;

            while (n > i)
            {
                n -= i;
                i++;
            }

            if (i % 2 == 1)
            {
                sb.Append(i + 1 - n);
                sb.Append('/');
                sb.Append(n);
            }
            else
            {
                sb.Append(n);
                sb.Append('/');
                sb.Append(i + 1 - n);
            }

            WriteLine(sb.ToString());
        }
    }
}