using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/5597

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            bool[] arr = new bool[31];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 28; i++)
            {
                int student = int.Parse(Console.ReadLine());

                arr[student] = true;
            }

            for (int i = 1; i <= 30; i++)
            {
                if (!arr[i])
                {
                    sb.AppendLine(i.ToString());
                }
            }

            Console.Write(sb);
        }
    }
}