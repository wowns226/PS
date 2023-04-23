using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/26068

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(ReadLine());
            int count = 0;

            while(n--> 0)
            {
                string input = ReadLine();
                input = input.Substring(2);
                int date = int.Parse(input);
                if(date <= 90)
                {
                    count++;
                }
            }
            sb.Append(count.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}