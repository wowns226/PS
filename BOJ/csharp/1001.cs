using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1001

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            var inputs = ReadLine().Split(' ').ToArray();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            sb.Append(a - b);

            Console.WriteLine(sb.ToString());
        }
    }
}